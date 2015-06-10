using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;



namespace Final_Project
{

    public partial class _Default : Page
    {

        public string Class1 = "";
        public string Class2 = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
            this.Title = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int counter;
            counter = 1;
            string[] classes = new string[10];
            string[] slideshow = new string[3];

            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("http://pastebin.com/raw.php?i=c394tBPL");

            string webData = System.Text.Encoding.UTF8.GetString(raw);


            var items = new List<string>();
            foreach (Match match in Regex.Matches(webData, "<li class=\"type_course depth_3 collapsed item_with_icon\"><p class=\"tree_item leaf hasicon\"(.*?)<img alt=\"\" class=\"smallicon navicon\" title="))
                items.Add(match.Groups[1].Value);
            string output = String.Join(" ", items);

            

            var names = new List<string>();
            foreach (Match match in Regex.Matches(output, "<a title=\"(.*?)\" href"))
                names.Add(match.Groups[1].Value);
            string namesList = String.Join(" ", names);

            string[] a = names.ToArray();

            for (counter = 1; counter < 10; counter++)
            {
                classes[0] = namesList;

            }
                TextBox2.Text = names[1];
                TextBox3.Text = names[2];
                TextBox4.Text = names[3];
                TextBox5.Text = names[4];
                TextBox6.Text = names[5];
                TextBox7.Text = names[6];
                TextBox8.Text = names[7];
                TextBox9.Text = names[8];
                TextBox10.Text = names[9];
                TextBox11.Text = names[10];

                slideshow[0] = "<p>Intermediate Algebra 9 - Shafer</p><br /><iframe src=\"https://docs.google.com/presentation/d/1Gfyl44l4Au0htBQrKPz_hZrlpVhEnhwbeTE_KbmbQME/embed?start=false&amp;loop=false&amp;delayms=3000\" allowfullscreen=\"true\" mozallowfullscreen=\"true\" webkitallowfullscreen=\"true\" frameborder=\"0\" height=\"299\" width=\"480\"></iframe>";
                slideshow[1] = "<p>Civics - Hubbell</p><br /><iframe src=\"https://docs.google.com/presentation/d/1-9ayPIZs7aUIBgTPo9dpuxm2R788k4DKlSs_A8EvROM/embed?start=false&amp;loop=false&amp;delayms=3000\" frameborder=\"0\" width=\"480\" height=\"389\" allowfullscreen=\"true\" mozallowfullscreen=\"true\" webkitallowfullscreen=\"true\"></iframe>";
                slideshow[2] = "";

                for (int i = 0; i <= 10; i++)
                {
                    if (names[i] == "Intermediate Algebra 9 - Shafer")
                    {
                        Class1 = slideshow[0];
                    }
                    else if (names[i] == "Civics - Hubbell")
                    {
                        Class2 = slideshow[1];
                    }
                    else if (names[i] == "")
                    {

                    }
                }
            

        }



        }
    }
