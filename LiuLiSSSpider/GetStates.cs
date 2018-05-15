using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace LiuLiSSSpider
{
    class GetStates
    {
        //public static ArrayList只是声明一个引用，而没有真正开辟空间。必须使用new开辟空间。
        //保存网址跳转变量
        public static ArrayList w_bianliang=new ArrayList();
        //保存网址跳转变量对应的名称
        public static ArrayList w_mingcheng=new ArrayList();
        //保存网址相同部分
        public static String jichuwangzhi=null;

        //此函数输入一个网址，以String类型返回html所有内容
        public static String GetHtml(String URL)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.KeepAlive = false;
            request.Timeout = 30 * 1000;
            //request.Host = "";
            request.Referer = "https://blog.reimu.net/";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.139 Safari/537.36";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream,Encoding.UTF8);

            String html = reader.ReadToEnd();
            return html;
        }


        //获取主页面的html,并且获取其中分类目录跳转到的网址
        public static void GetZhuHtml(String URL)
        {
            String html = GetHtml(URL);
            //获取分类目录的值与名称
            String bianliangRegex = @"<option\sclass=""level-0""\svalue=""(?<bianliang>\d*)""( selected=""selected"">|>)(?<mingcheng>\w*)</option>";
            Regex regex = new Regex(bianliangRegex, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.ExplicitCapture);
            var mates = regex.Matches(html);
 
            foreach(Match mate in mates)
            {
                w_bianliang.Add(mate.Groups["bianliang"].ToString());
                w_mingcheng.Add(mate.Groups["mingcheng"].ToString());
            }

            //获取变量所用的网址
            String wanghziRegex = @"location.href\s=\s""(?<wangzhi>.*?)""";
            Regex regex2 = new Regex(wanghziRegex, RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.ExplicitCapture);
            var mates2 = regex2.Match(html);
            jichuwangzhi = mates2.Groups["wangzhi"].ToString();
        }

        //获取分类目录中的网址和条目，并且存入对应的文件中
        public static void GetAllHtml(Form1 fulei,int n,int m,String xiancheng)
        {
            //获取所有分类目录的网址
            for(int i=n;i<=m;i++)
            {
                //得到了当前分类的第一页的网址
                 String URL = jichuwangzhi + w_bianliang[i].ToString();
                //得到了当前分类的第一页的所有内容
                //String URL = "https://blog.reimu.net/archives/category/anime/";
                String html;
                try
                {

                    html = GetHtml(URL);
                }
                catch
                {
                    
                    continue;
                }
                //获取当前分类的总页数
                Regex regexpage = new Regex(@"""https://blog\.reimu\.net/archives/category/(\w*)/page/(?<yeshu>\d*)"">(\w*)</a>\s</div>\s</main>", RegexOptions.Singleline | RegexOptions.Multiline);
                String Spages = regexpage.Match(html).Groups["yeshu"].ToString();

                int Ipages;

                try
                {
                    Ipages = int.Parse(Spages);
                }
                catch
                {
                    continue;
                }
                
                Regex regexjichu = new Regex(@"</span><a\s(class=""page\slarger"")\shref=""(?<wangzhi>.*?)(\d*)"">(\w*)</a>", RegexOptions.Singleline | RegexOptions.Multiline);
                String jichu = regexjichu.Match(html).Groups["wangzhi"].ToString();


                //获取当前分类的基础网址


                //对每一页进行读取。
                for (int j=0;j<Ipages;j++)
                {
                    //先组合成网址，并获得所有内容
                    String JURL = jichu + (j+1).ToString();

                    String html2;
                    try
                    {
                        html2 = GetHtml(JURL);
                    }
                    catch
                    {
                        
                        continue;
                    }

                    fulei.Invoke(new Action(() =>
                    {
                        fulei.t_loges.Text += ("线程:"+xiancheng+"正在爬取"+JURL+Environment.NewLine);
                    }
                        ));

                    //获取到了当前页面项目的标题和地址
                    Regex regex = new Regex(@"<h2\sclass=""entry-title""><a\shref=""(?<wangzhi>.*?)""\srel=""bookmark"">(?<biaoti>.*?)</a></h2>", RegexOptions.Singleline | RegexOptions.Multiline);
                    var matches = regex.Matches(html2);
                    int k = 0;
                    foreach (Match match in matches)
                    {
                        //获取单个项目的所有内容，用正则表达式取出每个项目的磁力链接，百度云链接，提取码和解压码
                        String XURL = match.Groups["wangzhi"].ToString();

                        String html3;
                        try
                        {
                            html3 = GetHtml(XURL);
                        }
                        catch
                        {
                            
                            continue;
                        }
                        
                        //html3=WebUtility.HtmlDecode(html3);
                        Regex regex2 = new Regex("<pre>(?<neirong>.*?)</pre>", RegexOptions.Singleline | RegexOptions.Multiline);
                        var match2 = regex2.Match(html3);//磁力的组会取得所有字符

                        //将各项内容填入文件中
                        FileStream fileStream = new FileStream(w_mingcheng[i] + ".txt", FileMode.Append);
                        StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);
                        //streamWriter.Write("标题:"+matches[k].Groups["biaoti"].ToString() + "磁力链接:"+match2.Groups["cililianjie"].ToString()+"百度云地址:" + match2.Groups["baiduyun"].ToString() + "提取码:" + match2.Groups["tiquma"].ToString() + "解压码" + match2.Groups["jieyama"].ToString() + Environment.NewLine);
                        streamWriter.Write("标题:" + matches[k].Groups["biaoti"].ToString() + "内容:" + match2.Groups["neirong"].ToString().Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "") + Environment.NewLine);
                        //MessageBox.Show(html3);
                        //String linshi= match2.Value.ToString();
                        //streamWriter.Write(@html3);
                        //MessageBox.Show(match2.Groups["neirong"].ToString());

                        streamWriter.Flush();
                        streamWriter.Close();
                        fileStream.Close();
                        k++;
                    }

                }
            }
        }
        
    }
}
