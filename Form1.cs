using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

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
        }

        // 선택 변경 시 실시간 주문 내역 업데이트
        private void SelectionChanged(object sender, EventArgs e)
        {
            UpdateOrderDisplay();
        }

        // 주문 내역 및 총 금액을 실시간으로 갱신
        private void UpdateOrderDisplay()
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

            // 메뉴가 선택되면 에러 메시지 초기화
            if (rbHamburger.Checked || rbBulgogi.Checked || rbChicken.Checked)
            {
                lblError.Text = "";
            }
        }

        // 주문하기 버튼 클릭
        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 메뉴 미선택 시 에러 메시지 표시
            if (!rbHamburger.Checked && !rbBulgogi.Checked && !rbChicken.Checked)
            {
                lblError.Text = "메뉴를 선택해주세요.";
                return;
            }

            // 에러 메시지 초기화
            lblError.Text = "";

            // 주문 내역 갱신
            UpdateOrderDisplay();
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

            // 주문 내역 및 에러 메시지 초기화
            lstOrder.Items.Clear();
            lblTotal.Text = "총 금액 : 0원";
            lblError.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picHamburger_Click(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // 라디오버튼 그룹 내 Tab 키 이동을 지원하기 위한 커스텀 처리 (윈도우 기본은 방향키)
            if (keyData == Keys.Tab)
            {
                if (grpMenu.Focused) { rbHamburger.Focus(); return true; }
                if (rbHamburger.Focused) { rbBulgogi.Focus(); return true; }
                if (rbBulgogi.Focused) { rbChicken.Focus(); return true; }
                if (rbChicken.Focused) { chkFries.Focus(); return true; }
                if (grpOptions.Focused) { chkFries.Focus(); return true; }
            }
            else if (keyData == (Keys.Shift | Keys.Tab))
            {
                if (chkFries.Focused) { rbChicken.Focus(); return true; }
                if (rbChicken.Focused) { rbBulgogi.Focus(); return true; }
                if (rbBulgogi.Focused) { rbHamburger.Focus(); return true; }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
