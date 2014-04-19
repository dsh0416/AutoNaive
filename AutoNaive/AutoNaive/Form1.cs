using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoNaive
{
    public partial class AutoNaive : Form
    {
        public AutoNaive()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtb_Output.Text = "";
            //Clear Screen
            rtb_Output.Text += txt_2.Text + "：你觉得" + txt_3.Text + "，好不好啊？\r\n";
            rtb_Output.Text += txt_1.Text + "：好喔！\r\n";
            rtb_Output.Text += txt_2.Text + "：" + txt_4.Text + "也支持哈？\r\n";
            rtb_Output.Text += txt_1.Text + "：当然啦！\r\n";
            rtb_Output.Text += txt_2.Text + "：那为什么这么早就决定了，而不考虑" + txt_5.Text + "了？\r\n";
            rtb_Output.Text += txt_2.Text + "：" + txt_6.Text + "呢，最近发表了一个报告说呢，" + txt_7.Text + "。你对这个看法有什么回应呢？\r\n";
            rtb_Output.Text += txt_1.Text + "：没听到过！\r\n";
            rtb_Output.Text += txt_2.Text + "：这是" + txt_8.Text + "说的。\r\n";
            rtb_Output.Text += txt_1.Text + "：" + txt_8.Text + "说的就是真的了？ 你们" + txt_9.Text + "千万要注意了，不要见着风是得雨，接到这些消息，" + txt_9.Text +"本身也要判断，明白这意思吗？ 假使这些完全无中生有的东西，你再帮他说一遍，你等于——你也有责任吧？\r\n";
            rtb_Output.Text += txt_2.Text + "：现在那么早，你们就说支持" + txt_11.Text + "，会不会给人一种感觉——就是内定呀？\r\n";
            rtb_Output.Text += txt_1.Text + "：没有，没有旁的意思！还是按照" + txt_12.Text + "、按照" + txt_13.Text + "、按照" + txt_14.Text + "……\r\n";
            rtb_Output.Text += txt_2.Text + "：但是你们能不能……\r\n";
            rtb_Output.Text += txt_1.Text + "：刚才你们问我呀，我可回答你说“无可奉告”。但是你们又不高兴，那怎么办？\r\n";
            rtb_Output.Text += txt_2.Text + "：可……\r\n";
            rtb_Output.Text += txt_1.Text + "：我讲的意思，不是钦点" + txt_15.Text + "。你问我支持不支持，我说支持。我就明确给你、告诉你。\r\n";
            rtb_Output.Text += txt_1.Text + "：但是你们吧，你们——我感觉你们" + txt_16.Text + "，还要学习一个——你们非常熟悉西方的那一套的理论，你们毕竟还too young!——明白这意思吗？我告诉你们，我是身经百战了！见得多了！西方的哪个国家我没去过？你们要知道，美国的" + txt_17.Text + "，那比你们不知要高到哪里去了！嗯，我和他谈笑风生。就是说"+txt_9.Text+"呀，还是要提高自己的知识水平。懂不懂呀？ \r\n";
            rtb_Output.Text += txt_1.Text + "：唉，我也替你们着急呀，真的。你们就——我以为整天的——你们有一个好——全世界跑到什么地方，你们比" + txt_18.Text + "，" + txt_19.Text + "！但是" + txt_20.Text + "呀，都too simple!啊~ sometimes naive!懂了没？\r\n";
            rtb_Output.Text += txt_2.Text + "：可……哦……\r\n";
            rtb_Output.Text += txt_1.Text + "：我很抱歉，我今天是作为一个长者，跟你们讲的！我不是"+txt_21.Text+"，但是我见得太多了……我不……有这个必要告诉你们一点，人生的经验。\r\n";
            rtb_Output.Text += txt_1.Text + "：刚才我很想啊，就我每次碰到你们，我就想到——中国 有句话叫“闷声发大财”。\r\n";
            rtb_Output.Text += txt_2.Text + "：那叫什么话？一句……\r\n";
            rtb_Output.Text += txt_1.Text + "：觉得什么话也不必说——这是最好的！但是我想我见到你们这样热情呀，一句话不说也不好。所以刚才你一定要……" + txt_22.Text + "，你们要负责！我没有说要钦定，没有任何这个意思。\r\n";
            rtb_Output.Text += txt_2.Text + "：但是说"+txt_24.Text+"呢？\r\n";
            rtb_Output.Text += txt_1.Text + "：哎，" + txt_24.Text + "也按照" + txt_25.Text + "，对不对？当然我们的" + txt_26.Text + "，也是很重要的！\r\n";
            rtb_Output.Text += txt_2.Text + "：但是呢……\r\n";
            rtb_Output.Text += txt_1.Text + "：明白这个意思吗？你们呀，不要喜欢，啊，弄那么个大新闻，说现在已经钦定了——就把我批判一番！\r\n";
            rtb_Output.Text += txt_2.Text + "：但是……\r\n";
            rtb_Output.Text += txt_1.Text + "：Naive Naive。你们呀……I Am Angry，你们这样子不行的。我今天算得罪了你们一下。\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(rtb_Output.Text);
        }


    }
}
