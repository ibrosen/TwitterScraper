using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
namespace tweetcleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader(File.Open(@"E:\pythonscripts\tweetscraper\tweets.txt", FileMode.Open));
            string s;
            List<string> texts = new List<string>();
            while (!f.EndOfStream)
            {
                s = f.ReadLine();
                if (string.IsNullOrEmpty(s))
                    continue;
                JToken token = JObject.Parse(s);
                var thing = Newtonsoft.Json.JsonConvert.DeserializeObject(s);
                var a = token.SelectToken("text").ToString();
                var lang = token.SelectToken("user").SelectToken("lang").ToString();
                if (lang.Equals("en"))
                {
                    if(!texts.Contains(a))
                    {
                        texts.Add(a);
                        texts.Add("\n");
                    }
                    
                }
            }
            //JToken token = JObject.Parse(stringFullOfJson);
            //StreamWriter stream = new StreamWriter(File.Open("C:/Users/ilanb_000/Source/Repos/tweetcleaner/tweetcleaner/justtext.txt", FileMode.OpenOrCreate));
            //stream.Write("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa im gonna die");
            File.WriteAllLines(@"E:\pythonscripts\tweetscraper\cleanedtweets.txt", texts);
        }
    }
}
