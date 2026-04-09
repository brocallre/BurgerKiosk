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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.rbHamburger = new System.Windows.Forms.RadioButton();
            this.rbBulgogi = new System.Windows.Forms.RadioButton();
            this.rbChicken = new System.Windows.Forms.RadioButton();
            this.picHamburger = new System.Windows.Forms.PictureBox();
            this.picBulgogi = new System.Windows.Forms.PictureBox();
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
            // lblTitle - 제목 라벨
            //
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(15, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 35);
            this.lblTitle.Text = "버거 주문 키오스크";
            //
            // grpMenu - 메뉴 선택 그룹
            //
            this.grpMenu.Controls.Add(this.rbHamburger);
            this.grpMenu.Controls.Add(this.picHamburger);
            this.grpMenu.Controls.Add(this.rbBulgogi);
            this.grpMenu.Controls.Add(this.picBulgogi);
            this.grpMenu.Controls.Add(this.rbChicken);
            this.grpMenu.Controls.Add(this.picChicken);
            this.grpMenu.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.grpMenu.ForeColor = System.Drawing.Color.Red;
            this.grpMenu.Location = new System.Drawing.Point(15, 48);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(240, 355);
            this.grpMenu.TabIndex = 0;
            this.grpMenu.TabStop = true;
            this.grpMenu.Text = "메뉴 선택";
            //
            // rbHamburger - 햄버거 라디오버튼
            //
            this.rbHamburger.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.rbHamburger.ForeColor = System.Drawing.Color.Black;
            this.rbHamburger.Location = new System.Drawing.Point(12, 28);
            this.rbHamburger.Name = "rbHamburger";
            this.rbHamburger.Size = new System.Drawing.Size(100, 22);
            this.rbHamburger.TabIndex = 0;
            this.rbHamburger.Text = "햄버거";
            this.rbHamburger.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            //
            // picHamburger - 햄버거 이미지
            //
            this.picHamburger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHamburger.Location = new System.Drawing.Point(115, 22);
            this.picHamburger.Name = "picHamburger";
            this.picHamburger.Size = new System.Drawing.Size(110, 85);
            this.picHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHamburger.TabStop = false;
            //
            // rbBulgogi - 불고기버거 라디오버튼
            //
            this.rbBulgogi.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.rbBulgogi.ForeColor = System.Drawing.Color.Black;
            this.rbBulgogi.Location = new System.Drawing.Point(12, 138);
            this.rbBulgogi.Name = "rbBulgogi";
            this.rbBulgogi.Size = new System.Drawing.Size(105, 22);
            this.rbBulgogi.TabIndex = 1;
            this.rbBulgogi.Text = "불고기버거";
            this.rbBulgogi.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            //
            // picBulgogi - 불고기버거 이미지
            //
            this.picBulgogi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBulgogi.Location = new System.Drawing.Point(115, 128);
            this.picBulgogi.Name = "picBulgogi";
            this.picBulgogi.Size = new System.Drawing.Size(110, 85);
            this.picBulgogi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBulgogi.TabStop = false;
            //
            // rbChicken - 치킨버거 라디오버튼
            //
            this.rbChicken.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.rbChicken.ForeColor = System.Drawing.Color.Black;
            this.rbChicken.Location = new System.Drawing.Point(12, 248);
            this.rbChicken.Name = "rbChicken";
            this.rbChicken.Size = new System.Drawing.Size(100, 22);
            this.rbChicken.TabIndex = 2;
            this.rbChicken.Text = "치킨버거";
            this.rbChicken.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            //
            // picChicken - 치킨버거 이미지
            //
            this.picChicken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picChicken.Location = new System.Drawing.Point(115, 238);
            this.picChicken.Name = "picChicken";
            this.picChicken.Size = new System.Drawing.Size(110, 85);
            this.picChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChicken.TabStop = false;
            //
            // grpOptions - 추가 옵션 그룹
            //
            this.grpOptions.Controls.Add(this.chkFries);
            this.grpOptions.Controls.Add(this.chkCola);
            this.grpOptions.Controls.Add(this.chkCheese);
            this.grpOptions.Controls.Add(this.chkSauce);
            this.grpOptions.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.grpOptions.ForeColor = System.Drawing.Color.Red;
            this.grpOptions.Location = new System.Drawing.Point(270, 48);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(160, 180);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = true;
            this.grpOptions.Text = "추가 옵션";
            //
            // chkFries - 감자튀김 체크박스
            //
            this.chkFries.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.chkFries.ForeColor = System.Drawing.Color.Black;
            this.chkFries.Location = new System.Drawing.Point(15, 32);
            this.chkFries.Name = "chkFries";
            this.chkFries.Size = new System.Drawing.Size(130, 22);
            this.chkFries.TabIndex = 0;
            this.chkFries.Text = "감자튀김";
            this.chkFries.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            //
            // chkCola - 콜라 체크박스
            //
            this.chkCola.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.chkCola.ForeColor = System.Drawing.Color.Black;
            this.chkCola.Location = new System.Drawing.Point(15, 67);
            this.chkCola.Name = "chkCola";
            this.chkCola.Size = new System.Drawing.Size(130, 22);
            this.chkCola.TabIndex = 1;
            this.chkCola.Text = "콜라";
            this.chkCola.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            //
            // chkCheese - 치즈 추가 체크박스
            //
            this.chkCheese.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.chkCheese.ForeColor = System.Drawing.Color.Black;
            this.chkCheese.Location = new System.Drawing.Point(15, 102);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(130, 22);
            this.chkCheese.TabIndex = 2;
            this.chkCheese.Text = "치즈 추가";
            this.chkCheese.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            //
            // chkSauce - 소스 추가 체크박스
            //
            this.chkSauce.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.chkSauce.ForeColor = System.Drawing.Color.Black;
            this.chkSauce.Location = new System.Drawing.Point(15, 137);
            this.chkSauce.Name = "chkSauce";
            this.chkSauce.Size = new System.Drawing.Size(130, 22);
            this.chkSauce.TabIndex = 3;
            this.chkSauce.Text = "소스 추가";
            this.chkSauce.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            //
            // grpOrder - 주문 내역 그룹
            //
            this.grpOrder.Controls.Add(this.lstOrder);
            this.grpOrder.Controls.Add(this.lblTotal);
            this.grpOrder.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.grpOrder.ForeColor = System.Drawing.Color.Red;
            this.grpOrder.Location = new System.Drawing.Point(445, 48);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(240, 355);
            this.grpOrder.TabIndex = 2;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "주문 내역";
            //
            // lstOrder - 주문 내역 리스트박스
            //
            this.lstOrder.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 17;
            this.lstOrder.Location = new System.Drawing.Point(12, 28);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(215, 276);
            this.lstOrder.TabIndex = 0;
            //
            // lblTotal - 총 금액 라벨
            //
            this.lblTotal.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(12, 318);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(215, 25);
            this.lblTotal.Text = "총 금액 : 0원";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // btnOrder - 주문하기 버튼
            //
            this.btnOrder.BackColor = System.Drawing.Color.Green;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(270, 418);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(130, 40);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "주문하기";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            //
            // btnReset - 초기화 버튼
            //
            this.btnReset.BackColor = System.Drawing.Color.Green;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(415, 418);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 40);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            //
            // lblError - 에러 메시지 라벨
            //
            this.lblError.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(270, 462);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(275, 22);
            this.lblError.Text = "";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 495);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblError);
            this.AcceptButton = this.btnOrder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burger Kiosk v1.0";
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
