namespace Project2OOP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNoMoreItems = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblYes = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAddToInventory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAppleInventory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMinusAS = new System.Windows.Forms.Button();
            this.lblQuanityAS = new System.Windows.Forms.Label();
            this.lblQuanityACR = new System.Windows.Forms.Label();
            this.btnAddAS = new System.Windows.Forms.Button();
            this.lblQuanityAC = new System.Windows.Forms.Label();
            this.btnMinusACR = new System.Windows.Forms.Button();
            this.btnAddAP = new System.Windows.Forms.Button();
            this.btnAddACR = new System.Windows.Forms.Button();
            this.lblQuanityAP = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnMinusAC = new System.Windows.Forms.Button();
            this.btnAddAC = new System.Windows.Forms.Button();
            this.btnMinusAP = new System.Windows.Forms.Button();
            this.lblApplesRemaining = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblASLineItemSubtotal = new System.Windows.Forms.Label();
            this.lblAppleSauce = new System.Windows.Forms.Label();
            this.lblAppleCrisp = new System.Windows.Forms.Label();
            this.lblACRLineItemSubtotal = new System.Windows.Forms.Label();
            this.lblAppleCider = new System.Windows.Forms.Label();
            this.lblACLineItemSubtotal = new System.Windows.Forms.Label();
            this.lblApplePie = new System.Windows.Forms.Label();
            this.lblAPLineItemSubtotal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstOutput1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstOutput3 = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClearAll = new System.Windows.Forms.Button();
            this.lstOutput2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNoMoreItems);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNo);
            this.groupBox1.Controls.Add(this.lblYes);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.btnAddToInventory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAppleInventory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Management System";
            // 
            // lblNoMoreItems
            // 
            this.lblNoMoreItems.AutoSize = true;
            this.lblNoMoreItems.ForeColor = System.Drawing.Color.Red;
            this.lblNoMoreItems.Location = new System.Drawing.Point(13, 80);
            this.lblNoMoreItems.Name = "lblNoMoreItems";
            this.lblNoMoreItems.Size = new System.Drawing.Size(201, 13);
            this.lblNoMoreItems.TabIndex = 21;
            this.lblNoMoreItems.Text = "No More Items can be added at this time.";
            this.lblNoMoreItems.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 39);
            this.label4.TabIndex = 20;
            this.label4.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Are there enough apples?";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Enabled = false;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.Red;
            this.lblNo.Location = new System.Drawing.Point(123, 39);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(74, 42);
            this.lblNo.TabIndex = 18;
            this.lblNo.Text = "NO";
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblYes.Location = new System.Drawing.Point(9, 39);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(93, 42);
            this.lblYes.TabIndex = 19;
            this.lblYes.Text = "YES";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(247, 32);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 5;
            // 
            // btnAddToInventory
            // 
            this.btnAddToInventory.Location = new System.Drawing.Point(247, 54);
            this.btnAddToInventory.Name = "btnAddToInventory";
            this.btnAddToInventory.Size = new System.Drawing.Size(101, 23);
            this.btnAddToInventory.TabIndex = 4;
            this.btnAddToInventory.Text = "Add to Inventory";
            this.btnAddToInventory.UseVisualStyleBackColor = true;
            this.btnAddToInventory.Click += new System.EventHandler(this.btnAddToInventory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apples in Inventory:";
            // 
            // lblAppleInventory
            // 
            this.lblAppleInventory.AutoSize = true;
            this.lblAppleInventory.Location = new System.Drawing.Point(337, 80);
            this.lblAppleInventory.Name = "lblAppleInventory";
            this.lblAppleInventory.Size = new System.Drawing.Size(25, 13);
            this.lblAppleInventory.TabIndex = 1;
            this.lblAppleInventory.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quanity To Add:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtClearAll);
            this.groupBox2.Controls.Add(this.btnMinusAS);
            this.groupBox2.Controls.Add(this.lblQuanityAS);
            this.groupBox2.Controls.Add(this.lblQuanityACR);
            this.groupBox2.Controls.Add(this.btnAddAS);
            this.groupBox2.Controls.Add(this.lblQuanityAC);
            this.groupBox2.Controls.Add(this.btnMinusACR);
            this.groupBox2.Controls.Add(this.btnAddAP);
            this.groupBox2.Controls.Add(this.btnAddACR);
            this.groupBox2.Controls.Add(this.lblQuanityAP);
            this.groupBox2.Controls.Add(this.btnPlaceOrder);
            this.groupBox2.Controls.Add(this.btnMinusAC);
            this.groupBox2.Controls.Add(this.btnAddAC);
            this.groupBox2.Controls.Add(this.btnMinusAP);
            this.groupBox2.Controls.Add(this.lblApplesRemaining);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblASLineItemSubtotal);
            this.groupBox2.Controls.Add(this.lblAppleSauce);
            this.groupBox2.Controls.Add(this.lblAppleCrisp);
            this.groupBox2.Controls.Add(this.lblACRLineItemSubtotal);
            this.groupBox2.Controls.Add(this.lblAppleCider);
            this.groupBox2.Controls.Add(this.lblACLineItemSubtotal);
            this.groupBox2.Controls.Add(this.lblApplePie);
            this.groupBox2.Controls.Add(this.lblAPLineItemSubtotal);
            this.groupBox2.Location = new System.Drawing.Point(0, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Form";
            // 
            // btnMinusAS
            // 
            this.btnMinusAS.Enabled = false;
            this.btnMinusAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinusAS.Location = new System.Drawing.Point(6, 87);
            this.btnMinusAS.Name = "btnMinusAS";
            this.btnMinusAS.Size = new System.Drawing.Size(21, 22);
            this.btnMinusAS.TabIndex = 18;
            this.btnMinusAS.Text = "-";
            this.btnMinusAS.UseVisualStyleBackColor = true;
            this.btnMinusAS.Click += new System.EventHandler(this.btnMinusAS_Click);
            // 
            // lblQuanityAS
            // 
            this.lblQuanityAS.AutoSize = true;
            this.lblQuanityAS.Location = new System.Drawing.Point(33, 92);
            this.lblQuanityAS.Name = "lblQuanityAS";
            this.lblQuanityAS.Size = new System.Drawing.Size(13, 13);
            this.lblQuanityAS.TabIndex = 24;
            this.lblQuanityAS.Text = "0";
            this.lblQuanityAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuanityACR
            // 
            this.lblQuanityACR.AutoSize = true;
            this.lblQuanityACR.Location = new System.Drawing.Point(33, 68);
            this.lblQuanityACR.Name = "lblQuanityACR";
            this.lblQuanityACR.Size = new System.Drawing.Size(13, 13);
            this.lblQuanityACR.TabIndex = 25;
            this.lblQuanityACR.Text = "0";
            this.lblQuanityACR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddAS
            // 
            this.btnAddAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddAS.Location = new System.Drawing.Point(52, 87);
            this.btnAddAS.Name = "btnAddAS";
            this.btnAddAS.Size = new System.Drawing.Size(21, 22);
            this.btnAddAS.TabIndex = 21;
            this.btnAddAS.Text = "+";
            this.btnAddAS.UseVisualStyleBackColor = true;
            this.btnAddAS.Click += new System.EventHandler(this.btnAddAS_Click);
            // 
            // lblQuanityAC
            // 
            this.lblQuanityAC.AutoSize = true;
            this.lblQuanityAC.Location = new System.Drawing.Point(33, 44);
            this.lblQuanityAC.Name = "lblQuanityAC";
            this.lblQuanityAC.Size = new System.Drawing.Size(13, 13);
            this.lblQuanityAC.TabIndex = 26;
            this.lblQuanityAC.Text = "0";
            this.lblQuanityAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinusACR
            // 
            this.btnMinusACR.Enabled = false;
            this.btnMinusACR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusACR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinusACR.Location = new System.Drawing.Point(6, 63);
            this.btnMinusACR.Name = "btnMinusACR";
            this.btnMinusACR.Size = new System.Drawing.Size(21, 22);
            this.btnMinusACR.TabIndex = 19;
            this.btnMinusACR.Text = "-";
            this.btnMinusACR.UseVisualStyleBackColor = true;
            this.btnMinusACR.Click += new System.EventHandler(this.btnMinusACR_Click);
            // 
            // btnAddAP
            // 
            this.btnAddAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddAP.Location = new System.Drawing.Point(52, 16);
            this.btnAddAP.Name = "btnAddAP";
            this.btnAddAP.Size = new System.Drawing.Size(21, 22);
            this.btnAddAP.TabIndex = 17;
            this.btnAddAP.Text = "+";
            this.btnAddAP.UseVisualStyleBackColor = true;
            this.btnAddAP.Click += new System.EventHandler(this.btnAddAP_Click);
            // 
            // btnAddACR
            // 
            this.btnAddACR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddACR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddACR.Location = new System.Drawing.Point(52, 63);
            this.btnAddACR.Name = "btnAddACR";
            this.btnAddACR.Size = new System.Drawing.Size(21, 22);
            this.btnAddACR.TabIndex = 22;
            this.btnAddACR.Text = "+";
            this.btnAddACR.UseVisualStyleBackColor = true;
            this.btnAddACR.Click += new System.EventHandler(this.btnAddACR_Click);
            // 
            // lblQuanityAP
            // 
            this.lblQuanityAP.AutoSize = true;
            this.lblQuanityAP.Location = new System.Drawing.Point(33, 19);
            this.lblQuanityAP.Name = "lblQuanityAP";
            this.lblQuanityAP.Size = new System.Drawing.Size(13, 13);
            this.lblQuanityAP.TabIndex = 15;
            this.lblQuanityAP.Text = "0";
            this.lblQuanityAP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(6, 146);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(182, 23);
            this.btnPlaceOrder.TabIndex = 14;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnMinusAC
            // 
            this.btnMinusAC.Enabled = false;
            this.btnMinusAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinusAC.Location = new System.Drawing.Point(6, 39);
            this.btnMinusAC.Name = "btnMinusAC";
            this.btnMinusAC.Size = new System.Drawing.Size(21, 22);
            this.btnMinusAC.TabIndex = 20;
            this.btnMinusAC.Text = "-";
            this.btnMinusAC.UseVisualStyleBackColor = true;
            this.btnMinusAC.Click += new System.EventHandler(this.btnMinusAC_Click);
            // 
            // btnAddAC
            // 
            this.btnAddAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddAC.Location = new System.Drawing.Point(52, 39);
            this.btnAddAC.Name = "btnAddAC";
            this.btnAddAC.Size = new System.Drawing.Size(21, 22);
            this.btnAddAC.TabIndex = 23;
            this.btnAddAC.Text = "+";
            this.btnAddAC.UseVisualStyleBackColor = true;
            this.btnAddAC.Click += new System.EventHandler(this.btnAddAC_Click);
            // 
            // btnMinusAP
            // 
            this.btnMinusAP.Enabled = false;
            this.btnMinusAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinusAP.Location = new System.Drawing.Point(6, 16);
            this.btnMinusAP.Name = "btnMinusAP";
            this.btnMinusAP.Size = new System.Drawing.Size(21, 22);
            this.btnMinusAP.TabIndex = 16;
            this.btnMinusAP.Text = "-";
            this.btnMinusAP.UseVisualStyleBackColor = true;
            this.btnMinusAP.Click += new System.EventHandler(this.btnMinusAP_Click);
            // 
            // lblApplesRemaining
            // 
            this.lblApplesRemaining.AutoSize = true;
            this.lblApplesRemaining.Location = new System.Drawing.Point(104, 121);
            this.lblApplesRemaining.Name = "lblApplesRemaining";
            this.lblApplesRemaining.Size = new System.Drawing.Size(25, 13);
            this.lblApplesRemaining.TabIndex = 13;
            this.lblApplesRemaining.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Apples Remaining:";
            // 
            // lblASLineItemSubtotal
            // 
            this.lblASLineItemSubtotal.AutoSize = true;
            this.lblASLineItemSubtotal.Location = new System.Drawing.Point(160, 92);
            this.lblASLineItemSubtotal.Name = "lblASLineItemSubtotal";
            this.lblASLineItemSubtotal.Size = new System.Drawing.Size(34, 13);
            this.lblASLineItemSubtotal.TabIndex = 11;
            this.lblASLineItemSubtotal.Text = "$1.75";
            // 
            // lblAppleSauce
            // 
            this.lblAppleSauce.AutoSize = true;
            this.lblAppleSauce.Location = new System.Drawing.Point(78, 92);
            this.lblAppleSauce.Name = "lblAppleSauce";
            this.lblAppleSauce.Size = new System.Drawing.Size(83, 13);
            this.lblAppleSauce.TabIndex = 10;
            this.lblAppleSauce.Text = "APPLE SAUCE:";
            // 
            // lblAppleCrisp
            // 
            this.lblAppleCrisp.AutoSize = true;
            this.lblAppleCrisp.Location = new System.Drawing.Point(78, 68);
            this.lblAppleCrisp.Name = "lblAppleCrisp";
            this.lblAppleCrisp.Size = new System.Drawing.Size(79, 13);
            this.lblAppleCrisp.TabIndex = 9;
            this.lblAppleCrisp.Text = "APPLE CRISP:";
            // 
            // lblACRLineItemSubtotal
            // 
            this.lblACRLineItemSubtotal.AutoSize = true;
            this.lblACRLineItemSubtotal.Location = new System.Drawing.Point(154, 68);
            this.lblACRLineItemSubtotal.Name = "lblACRLineItemSubtotal";
            this.lblACRLineItemSubtotal.Size = new System.Drawing.Size(34, 13);
            this.lblACRLineItemSubtotal.TabIndex = 8;
            this.lblACRLineItemSubtotal.Text = "$9.85";
            // 
            // lblAppleCider
            // 
            this.lblAppleCider.AutoSize = true;
            this.lblAppleCider.Location = new System.Drawing.Point(76, 44);
            this.lblAppleCider.Name = "lblAppleCider";
            this.lblAppleCider.Size = new System.Drawing.Size(80, 13);
            this.lblAppleCider.TabIndex = 7;
            this.lblAppleCider.Text = "APPLE CIDER:";
            // 
            // lblACLineItemSubtotal
            // 
            this.lblACLineItemSubtotal.AutoSize = true;
            this.lblACLineItemSubtotal.Location = new System.Drawing.Point(154, 44);
            this.lblACLineItemSubtotal.Name = "lblACLineItemSubtotal";
            this.lblACLineItemSubtotal.Size = new System.Drawing.Size(34, 13);
            this.lblACLineItemSubtotal.TabIndex = 6;
            this.lblACLineItemSubtotal.Text = "$2.75";
            // 
            // lblApplePie
            // 
            this.lblApplePie.AutoSize = true;
            this.lblApplePie.Location = new System.Drawing.Point(78, 19);
            this.lblApplePie.Name = "lblApplePie";
            this.lblApplePie.Size = new System.Drawing.Size(64, 13);
            this.lblApplePie.TabIndex = 5;
            this.lblApplePie.Text = "APPLE PIE:";
            // 
            // lblAPLineItemSubtotal
            // 
            this.lblAPLineItemSubtotal.AutoSize = true;
            this.lblAPLineItemSubtotal.Location = new System.Drawing.Point(148, 19);
            this.lblAPLineItemSubtotal.Name = "lblAPLineItemSubtotal";
            this.lblAPLineItemSubtotal.Size = new System.Drawing.Size(40, 13);
            this.lblAPLineItemSubtotal.TabIndex = 4;
            this.lblAPLineItemSubtotal.Text = "$12.50";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstOutput1);
            this.groupBox3.Location = new System.Drawing.Point(206, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 206);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receipt";
            // 
            // lstOutput1
            // 
            this.lstOutput1.FormattingEnabled = true;
            this.lstOutput1.Location = new System.Drawing.Point(3, 16);
            this.lstOutput1.Name = "lstOutput1";
            this.lstOutput1.Size = new System.Drawing.Size(156, 186);
            this.lstOutput1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstOutput2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lstOutput3);
            this.groupBox4.Location = new System.Drawing.Point(3, 315);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 225);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Purchase History";
            // 
            // lstOutput3
            // 
            this.lstOutput3.FormattingEnabled = true;
            this.lstOutput3.Location = new System.Drawing.Point(173, 52);
            this.lstOutput3.Name = "lstOutput3";
            this.lstOutput3.Size = new System.Drawing.Size(175, 160);
            this.lstOutput3.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select Historical Order To View";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Historical Reciept";
            // 
            // txtClearAll
            // 
            this.txtClearAll.Location = new System.Drawing.Point(6, 177);
            this.txtClearAll.Name = "txtClearAll";
            this.txtClearAll.Size = new System.Drawing.Size(182, 23);
            this.txtClearAll.TabIndex = 4;
            this.txtClearAll.Text = "Clear All";
            this.txtClearAll.UseVisualStyleBackColor = true;
            this.txtClearAll.Click += new System.EventHandler(this.txtClearAll_Click);
            // 
            // lstOutput2
            // 
            this.lstOutput2.FormattingEnabled = true;
            this.lstOutput2.Location = new System.Drawing.Point(9, 52);
            this.lstOutput2.Name = "lstOutput2";
            this.lstOutput2.Size = new System.Drawing.Size(151, 160);
            this.lstOutput2.TabIndex = 6;
            this.lstOutput2.SelectedIndexChanged += new System.EventHandler(this.lstOutput2_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 552);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Griffin-Project 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAddToInventory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAppleInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblApplesRemaining;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblASLineItemSubtotal;
        private System.Windows.Forms.Label lblAppleSauce;
        private System.Windows.Forms.Label lblAppleCrisp;
        private System.Windows.Forms.Label lblACRLineItemSubtotal;
        private System.Windows.Forms.Label lblAppleCider;
        private System.Windows.Forms.Label lblACLineItemSubtotal;
        private System.Windows.Forms.Label lblApplePie;
        private System.Windows.Forms.Label lblAPLineItemSubtotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstOutput1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddAP;
        private System.Windows.Forms.Label lblQuanityAP;
        private System.Windows.Forms.Button btnMinusAP;
        private System.Windows.Forms.Button btnMinusAS;
        private System.Windows.Forms.Label lblQuanityAS;
        private System.Windows.Forms.Label lblQuanityACR;
        private System.Windows.Forms.Button btnAddAS;
        private System.Windows.Forms.Label lblQuanityAC;
        private System.Windows.Forms.Button btnMinusACR;
        private System.Windows.Forms.Button btnAddACR;
        private System.Windows.Forms.Button btnMinusAC;
        private System.Windows.Forms.Button btnAddAC;
        private System.Windows.Forms.ListBox lstOutput3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNoMoreItems;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txtClearAll;
        private System.Windows.Forms.ListBox lstOutput2;
    }
}

