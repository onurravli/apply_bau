using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;

namespace nihani
{
    public partial class giris : Form
    {
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        

        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                ContTrain = ContTrain + 1;
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(textBox1.Text);
                imageBox1.Image = TrainedFace;
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", 
                trainingImages.ToArray().Length.ToString() + "%");
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + 
                "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", 
                        labels.ToArray()[i - 1] + "%");
                }
                MessageBox.Show(textBox1.Text + " kişisinin yüzü kaydedildi.", "Kaydedildi.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
        }

        private void anamenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            acilis acilis = new acilis();
            acilis.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(854, 703);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            groupBox4.Size = new System.Drawing.Size(820, 282);
            groupBox3.Size = new System.Drawing.Size(814, 342);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(466, 703);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            groupBox4.Size = new System.Drawing.Size(430, 282);
            groupBox3.Size = new System.Drawing.Size(12, 315);
        }

        private void şİFREİLEGİRİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gÖSTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(854, 576);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            groupBox4.Size = new System.Drawing.Size(820, 282);
            groupBox3.Size = new System.Drawing.Size(814, 210);
        }

        private void gİZLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(466, 576);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            groupBox4.Size = new System.Drawing.Size(430, 282);
            groupBox3.Size = new System.Drawing.Size(430, 210);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pin.Text = pin.Text + "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pin.Text = pin.Text + "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pin.Text = pin.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pin.Text = pin.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pin.Text = pin.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pin.Text = pin.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pin.Text = pin.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pin.Text = pin.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pin.Text = pin.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pin.Text = pin.Text + "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            /*if(pin.Text == "6687")
            {
                this.Hide();
                acilis acilis = new acilis();
                acilis.Show();
            }
            else
            {
                MessageBox.Show("YANLIŞ PIN");
            }
            */
        }


        private void button14_Click(object sender, EventArgs e)
        {
            pin.Text = "";
        }

        private void sil_Click(object sender, EventArgs e)
        {
            pin.Text = "";
        }

        private void pin_TextChanged(object sender, EventArgs e)
        {
            if(pin.Text == "6687")
            {
                this.Hide();
                acilis acilis = new acilis();
                acilis.Show();
            }
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {

        }

        public giris()
        {
            InitializeComponent();
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;
                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }
            }
            catch (Exception e)
            {
            }
        }

        void FrameGrabber(object sender, EventArgs e)
        {
            label3.Text = "0";
            NamePersons.Add("");
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            gray = currentFrame.Convert<Gray, Byte>();
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
          face,
          1.2,
          10,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);
                if (trainingImages.ToArray().Length != 0)
                {
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       3000,
                       ref termCrit);
                    name = recognizer.Recognize(result);
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen)); 
                }
                NamePersons[t - 1] = name;
                NamePersons.Add("");
                label3.Text = facesDetected[0].Length.ToString();               
            }
            t = 0;
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + ", ";
                for (int i = 0; i < 1; i++)
                {
                    DialogResult dialogResult = MessageBox.Show("Şifreleme Ekranı Açılsın Mı?", "Yüz Tanındı", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Application.OpenForms["acilis"] == null)
                        {
                            this.Hide();
                            acilis acilis = new acilis();
                            acilis.Show();
                        }
                        else
                        {

                        }
                    }
                } 
            }
           
            imageBoxFrameGrabber.Image = currentFrame;
            label4.Text = names;
            names = "";
            NamePersons.Clear();
        }

        private void yuztani_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(466, 576);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            try
            {
                grabber = new Capture();
                grabber.QueryFrame();
                Application.Idle += new EventHandler(FrameGrabber);
            }
            catch
            {
                MessageBox.Show("KAMERA BAŞLATILIRKEN HATA OLUŞTU!");
            }
        }
    }
}
