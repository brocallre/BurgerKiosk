namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.rbHamburger = new System.Windows.Forms.RadioButton();
            this.picHamburger = new System.Windows.Forms.PictureBox();
            this.rbBulgogi = new System.Windows.Forms.RadioButton();
            this.picBulgogi = new System.Windows.Forms.PictureBox();
            this.rbChicken = new System.Windows.Forms.RadioButton();
            this.picChicken = new System.Windows.Forms.PictureBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkFries = new System.Windows.Forms.CheckBox();
            this.chkCola = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkSauce = new System.Windows.Forms.CheckBox();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHamburger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBulgogi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChicken)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(39, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(720, 88);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "버거 주문 키오스크";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.rbHamburger);
            this.grpMenu.Controls.Add(this.picHamburger);
            this.grpMenu.Controls.Add(this.rbBulgogi);
            this.grpMenu.Controls.Add(this.picBulgogi);
            this.grpMenu.Controls.Add(this.rbChicken);
            this.grpMenu.Controls.Add(this.picChicken);
            this.grpMenu.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.grpMenu.ForeColor = System.Drawing.Color.Red;
            this.grpMenu.Location = new System.Drawing.Point(39, 120);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpMenu.Size = new System.Drawing.Size(617, 888);
            this.grpMenu.TabIndex = 0;
            this.grpMenu.Text = "메뉴 선택";
            // 
            // rbHamburger
            // 
            this.rbHamburger.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.rbHamburger.ForeColor = System.Drawing.Color.Black;
            this.rbHamburger.Location = new System.Drawing.Point(31, 70);
            this.rbHamburger.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rbHamburger.Name = "rbHamburger";
            this.rbHamburger.Size = new System.Drawing.Size(257, 55);
            this.rbHamburger.TabIndex = 0;
            this.rbHamburger.Text = "햄버거";
            this.rbHamburger.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // picHamburger
            // 
            this.picHamburger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHamburger.Image = ((System.Drawing.Image)(resources.GetObject("picHamburger.Image")));
            this.picHamburger.Location = new System.Drawing.Point(296, 55);
            this.picHamburger.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.picHamburger.Name = "picHamburger";
            this.picHamburger.Size = new System.Drawing.Size(280, 210);
            this.picHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHamburger.TabIndex = 1;
            this.picHamburger.TabStop = false;
            this.picHamburger.Click += new System.EventHandler(this.picHamburger_Click);
            // 
            // rbBulgogi
            // 
            this.rbBulgogi.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.rbBulgogi.ForeColor = System.Drawing.Color.Black;
            this.rbBulgogi.Location = new System.Drawing.Point(31, 345);
            this.rbBulgogi.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rbBulgogi.Name = "rbBulgogi";
            this.rbBulgogi.Size = new System.Drawing.Size(230, 55);
            this.rbBulgogi.TabIndex = 1;
            this.rbBulgogi.Text = "불고기버거";
            this.rbBulgogi.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // picBulgogi
            // 
            this.picBulgogi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBulgogi.Image = ((System.Drawing.Image)(resources.GetObject("picBulgogi.Image")));
            this.picBulgogi.Location = new System.Drawing.Point(296, 320);
            this.picBulgogi.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.picBulgogi.Name = "picBulgogi";
            this.picBulgogi.Size = new System.Drawing.Size(280, 210);
            this.picBulgogi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBulgogi.TabIndex = 2;
            this.picBulgogi.TabStop = false;
            // 
            // rbChicken
            // 
            this.rbChicken.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.rbChicken.ForeColor = System.Drawing.Color.Black;
            this.rbChicken.Location = new System.Drawing.Point(31, 620);
            this.rbChicken.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rbChicken.Name = "rbChicken";
            this.rbChicken.Size = new System.Drawing.Size(257, 55);
            this.rbChicken.TabIndex = 2;
            this.rbChicken.Text = "치킨버거";
            this.rbChicken.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // picChicken
            // 
            this.picChicken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picChicken.Image = ((System.Drawing.Image)(resources.GetObject("picChicken.Image")));
            this.picChicken.Location = new System.Drawing.Point(296, 595);
            this.picChicken.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.picChicken.Name = "picChicken";
            this.picChicken.Size = new System.Drawing.Size(280, 210);
            this.picChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChicken.TabIndex = 3;
            this.picChicken.TabStop = false;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkFries);
            this.grpOptions.Controls.Add(this.chkCola);
            this.grpOptions.Controls.Add(this.chkCheese);
            this.grpOptions.Controls.Add(this.chkSauce);
            this.grpOptions.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.grpOptions.ForeColor = System.Drawing.Color.Red;
            this.grpOptions.Location = new System.Drawing.Point(694, 120);
            this.grpOptions.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpOptions.Size = new System.Drawing.Size(411, 450);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.Text = "추가 옵션";
            // 
            // chkFries
            // 
            this.chkFries.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.chkFries.ForeColor = System.Drawing.Color.Black;
            this.chkFries.Location = new System.Drawing.Point(39, 80);
            this.chkFries.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.chkFries.Name = "chkFries";
            this.chkFries.Size = new System.Drawing.Size(334, 55);
            this.chkFries.TabIndex = 0;
            this.chkFries.Text = "감자튀김";
            this.chkFries.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // chkCola
            // 
            this.chkCola.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.chkCola.ForeColor = System.Drawing.Color.Black;
            this.chkCola.Location = new System.Drawing.Point(39, 168);
            this.chkCola.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.chkCola.Name = "chkCola";
            this.chkCola.Size = new System.Drawing.Size(334, 55);
            this.chkCola.TabIndex = 1;
            this.chkCola.Text = "콜라";
            this.chkCola.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // chkCheese
            // 
            this.chkCheese.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.chkCheese.ForeColor = System.Drawing.Color.Black;
            this.chkCheese.Location = new System.Drawing.Point(39, 255);
            this.chkCheese.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(334, 55);
            this.chkCheese.TabIndex = 2;
            this.chkCheese.Text = "치즈 추가";
            this.chkCheese.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // chkSauce
            // 
            this.chkSauce.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.chkSauce.ForeColor = System.Drawing.Color.Black;
            this.chkSauce.Location = new System.Drawing.Point(39, 342);
            this.chkSauce.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.chkSauce.Name = "chkSauce";
            this.chkSauce.Size = new System.Drawing.Size(334, 55);
            this.chkSauce.TabIndex = 3;
            this.chkSauce.Text = "소스 추가";
            this.chkSauce.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lstOrder);
            this.grpOrder.Controls.Add(this.lblTotal);
            this.grpOrder.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.grpOrder.ForeColor = System.Drawing.Color.Red;
            this.grpOrder.Location = new System.Drawing.Point(1144, 120);
            this.grpOrder.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpOrder.Size = new System.Drawing.Size(617, 888);
            this.grpOrder.TabIndex = 2;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "주문 내역";
            // 
            // lstOrder
            // 
            this.lstOrder.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 45;
            this.lstOrder.Location = new System.Drawing.Point(31, 70);
            this.lstOrder.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(547, 679);
            this.lstOrder.TabIndex = 0;
            this.lstOrder.SelectedIndexChanged += new System.EventHandler(this.lstOrder_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(31, 795);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(553, 62);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "총 금액 : 0원";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Green;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(694, 1045);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(334, 100);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "주문하기";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1067, 1045);
            this.btnReset.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(334, 100);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(694, 1155);
            this.lblError.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(707, 55);
            this.lblError.TabIndex = 5;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 1238);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burger Kiosk v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHamburger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBulgogi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChicken)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.RadioButton rbHamburger;
        private System.Windows.Forms.RadioButton rbBulgogi;
        private System.Windows.Forms.RadioButton rbChicken;
        private System.Windows.Forms.PictureBox picHamburger;
        private System.Windows.Forms.PictureBox picBulgogi;
        private System.Windows.Forms.PictureBox picChicken;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkFries;
        private System.Windows.Forms.CheckBox chkCola;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkSauce;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblError;
    }
}
