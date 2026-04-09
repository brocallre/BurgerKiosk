using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        // 메뉴 가격 정보
        private readonly int priceHamburger = 5000;
        private readonly int priceBulgogi = 6500;
        private readonly int priceChicken = 6000;

        // 옵션 가격 정보
        private readonly int priceFries = 2000;
        private readonly int priceCola = 1500;
        private readonly int priceCheese = 500;
        private readonly int priceSauce = 300;

        public Form1()
        {
            InitializeComponent();
            LoadBurgerImages();
        }

        // 버거 이미지를 로드하거나 없으면 플레이스홀더 생성
        private void LoadBurgerImages()
        {
            string imgPath = Path.Combine(Application.StartupPath, "img");

            // img 폴더가 없으면 생성
            if (!Directory.Exists(imgPath))
            {
                Directory.CreateDirectory(imgPath);
            }

            // 각 버거 이미지 로드 또는 플레이스홀더 생성
            picHamburger.Image = LoadOrCreateImage(Path.Combine(imgPath, "hamburger.png"), "햄버거", Color.SandyBrown);
            picBulgogi.Image = LoadOrCreateImage(Path.Combine(imgPath, "bulgogi.png"), "불고기버거", Color.SaddleBrown);
            picChicken.Image = LoadOrCreateImage(Path.Combine(imgPath, "chicken.png"), "치킨버거", Color.Goldenrod);
        }

        // 이미지 파일이 있으면 로드, 없으면 플레이스홀더 이미지 생성
        private Image LoadOrCreateImage(string filePath, string text, Color bgColor)
        {
            if (File.Exists(filePath))
            {
                return Image.FromFile(filePath);
            }

            // 플레이스홀더 이미지 생성
            Bitmap bmp = new Bitmap(200, 150);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(bgColor);
                using (Font font = new Font("맑은 고딕", 14F, FontStyle.Bold))
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString(text, font, Brushes.White, new RectangleF(0, 0, 200, 150), sf);
                }
            }
            return bmp;
        }

        // 주문하기 버튼 클릭
        private void btnOrder_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();
            int totalPrice = 0;

            // 선택된 메뉴 확인
            if (rbHamburger.Checked)
            {
                lstOrder.Items.Add("햄버거 " + priceHamburger.ToString("N0") + "원");
                totalPrice += priceHamburger;
            }
            else if (rbBulgogi.Checked)
            {
                lstOrder.Items.Add("불고기버거 " + priceBulgogi.ToString("N0") + "원");
                totalPrice += priceBulgogi;
            }
            else if (rbChicken.Checked)
            {
                lstOrder.Items.Add("치킨버거 " + priceChicken.ToString("N0") + "원");
                totalPrice += priceChicken;
            }

            // 선택된 옵션 확인
            if (chkFries.Checked)
            {
                lstOrder.Items.Add("감자튀김 " + priceFries.ToString("N0") + "원");
                totalPrice += priceFries;
            }
            if (chkCola.Checked)
            {
                lstOrder.Items.Add("콜라 " + priceCola.ToString("N0") + "원");
                totalPrice += priceCola;
            }
            if (chkCheese.Checked)
            {
                lstOrder.Items.Add("치즈 추가 " + priceCheese.ToString("N0") + "원");
                totalPrice += priceCheese;
            }
            if (chkSauce.Checked)
            {
                lstOrder.Items.Add("소스 추가 " + priceSauce.ToString("N0") + "원");
                totalPrice += priceSauce;
            }

            // 총 금액 표시
            lblTotal.Text = "총 금액 : " + totalPrice.ToString("N0") + "원";
        }

        // 초기화 버튼 클릭
        private void btnReset_Click(object sender, EventArgs e)
        {
            // 라디오버튼 초기화
            rbHamburger.Checked = false;
            rbBulgogi.Checked = false;
            rbChicken.Checked = false;

            // 체크박스 초기화
            chkFries.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            // 주문 내역 초기화
            lstOrder.Items.Clear();
            lblTotal.Text = "총 금액 : 0원";
        }
    }
}
