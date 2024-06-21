namespace FinalProject.UI
{
	partial class ShopForm
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
			User_Id = new TextBox();
			label_user_id = new Label();
			listBox_Products = new ListBox();
			listBox_Cart = new ListBox();
			button_add_to_cart = new Button();
			button_Buy = new Button();
			label_Balance = new Label();
			textBox_Balance = new TextBox();
			label_Quantity = new Label();
			numericUpDown_quantity = new NumericUpDown();
			label_Total_Cost = new Label();
			textBox_Total = new TextBox();
			((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).BeginInit();
			SuspendLayout();
			// 
			// User_Id
			// 
			User_Id.Location = new Point(996, 30);
			User_Id.Name = "User_Id";
			User_Id.Size = new Size(216, 23);
			User_Id.TabIndex = 1;
			// 
			// label_user_id
			// 
			label_user_id.AutoSize = true;
			label_user_id.Location = new Point(970, 33);
			label_user_id.Name = "label_user_id";
			label_user_id.Size = new Size(20, 15);
			label_user_id.TabIndex = 3;
			label_user_id.Text = "Id:";
			// 
			// listBox_Products
			// 
			listBox_Products.FormattingEnabled = true;
			listBox_Products.ItemHeight = 15;
			listBox_Products.Location = new Point(223, 117);
			listBox_Products.Name = "listBox_Products";
			listBox_Products.Size = new Size(279, 214);
			listBox_Products.TabIndex = 4;
			listBox_Products.SelectedIndexChanged += listBox_Products_SelectedIndexChanged;
			// 
			// listBox_Cart
			// 
			listBox_Cart.FormattingEnabled = true;
			listBox_Cart.ItemHeight = 15;
			listBox_Cart.Location = new Point(768, 117);
			listBox_Cart.Name = "listBox_Cart";
			listBox_Cart.Size = new Size(279, 214);
			listBox_Cart.TabIndex = 5;
			listBox_Cart.SelectedIndexChanged += listBox_Cart_SelectedIndexChanged;
			// 
			// button_add_to_cart
			// 
			button_add_to_cart.Location = new Point(316, 437);
			button_add_to_cart.Name = "button_add_to_cart";
			button_add_to_cart.Size = new Size(75, 23);
			button_add_to_cart.TabIndex = 6;
			button_add_to_cart.Text = "Add";
			button_add_to_cart.UseVisualStyleBackColor = true;
			button_add_to_cart.Click += button_add_to_cart_Click;
			// 
			// button_Buy
			// 
			button_Buy.Location = new Point(874, 437);
			button_Buy.Name = "button_Buy";
			button_Buy.Size = new Size(75, 23);
			button_Buy.TabIndex = 7;
			button_Buy.Text = "Buy";
			button_Buy.UseVisualStyleBackColor = true;
			button_Buy.Click += button_Buy_Click;
			// 
			// label_Balance
			// 
			label_Balance.AutoSize = true;
			label_Balance.Location = new Point(529, 529);
			label_Balance.Name = "label_Balance";
			label_Balance.Size = new Size(54, 15);
			label_Balance.TabIndex = 8;
			label_Balance.Text = "Balance: ";
			// 
			// textBox_Balance
			// 
			textBox_Balance.Location = new Point(589, 526);
			textBox_Balance.Name = "textBox_Balance";
			textBox_Balance.Size = new Size(103, 23);
			textBox_Balance.TabIndex = 9;
			textBox_Balance.TextChanged += textBox1_TextChanged;
			// 
			// label_Quantity
			// 
			label_Quantity.AutoSize = true;
			label_Quantity.Location = new Point(251, 364);
			label_Quantity.Name = "label_Quantity";
			label_Quantity.Size = new Size(59, 15);
			label_Quantity.TabIndex = 11;
			label_Quantity.Text = "Quantity: ";
			// 
			// numericUpDown_quantity
			// 
			numericUpDown_quantity.Location = new Point(316, 362);
			numericUpDown_quantity.Name = "numericUpDown_quantity";
			numericUpDown_quantity.Size = new Size(120, 23);
			numericUpDown_quantity.TabIndex = 12;
			// 
			// label_Total_Cost
			// 
			label_Total_Cost.AutoSize = true;
			label_Total_Cost.Location = new Point(821, 365);
			label_Total_Cost.Name = "label_Total_Cost";
			label_Total_Cost.Size = new Size(38, 15);
			label_Total_Cost.TabIndex = 13;
			label_Total_Cost.Text = "Total: ";
			// 
			// textBox_Total
			// 
			textBox_Total.Location = new Point(874, 362);
			textBox_Total.Name = "textBox_Total";
			textBox_Total.Size = new Size(103, 23);
			textBox_Total.TabIndex = 14;
			// 
			// ShopForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1224, 634);
			Controls.Add(textBox_Total);
			Controls.Add(label_Total_Cost);
			Controls.Add(numericUpDown_quantity);
			Controls.Add(label_Quantity);
			Controls.Add(textBox_Balance);
			Controls.Add(label_Balance);
			Controls.Add(button_Buy);
			Controls.Add(button_add_to_cart);
			Controls.Add(listBox_Cart);
			Controls.Add(listBox_Products);
			Controls.Add(label_user_id);
			Controls.Add(User_Id);
			Name = "ShopForm";
			Text = "ShopForm";
			Load += ShopForm_Load;
			((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox User_Id;
		private Label label_user_id;
		private ListBox listBox_Products;
		private ListBox listBox_Cart;
		private Button button_add_to_cart;
		private Button button_Buy;
		private Label label_Balance;
		private TextBox textBox_Balance;
		private Label label_Quantity;
		private NumericUpDown numericUpDown_quantity;
		private Label label_Total_Cost;
		private TextBox textBox_Total;
	}
}