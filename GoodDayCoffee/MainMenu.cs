using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace GoodDayCoffee
{
    public partial class MainMenu : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=KHYLE-PC;Initial Catalog=GoodDayCoffee;Integrated Security=True;Pooling=False");
        int ID;
        string description;
        string imageFile;
        string sql;
        int index = -1;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            sql = "SELECT CoffeeName AS [Name], CoffeeType AS [Type], CoffeeOrigin AS [Origin], CoffeeStrength AS [Strength], CoffeePrice AS [Price], CoffeeQuantity AS [Quantity], CoffeeImage, CoffeeDesc, CoffeeId  FROM Coffee";
            //sql = "SELECT CoffeeName AS [Name], CoffeeType AS [Type], CoffeeOrigin AS [Origin], CoffeeStrength AS [Strength], CoffeePrice AS [Price], CoffeeQuantity AS [Quantity], CoffeeImage, CoffeeDesc, CoffeeId  FROM Coffee";
            BindDataToGrid();
            
            this.dg_Coffee.Columns[6].Visible = false;
            this.dg_Coffee.Columns[7].Visible = false;
            this.dg_Coffee.Columns[8].Visible = false;

            CheckLowStocks();
            CheckStocks();


            sql = "SELECT * FROM [Order]";
            BindOrderToGrid();
        }

        private void BindDataToGrid()
        {
            
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataTable ds = new DataTable();
            conn.Open();
            dataadapter.Fill(ds);
            conn.Close();
            dg_Coffee.DataSource = ds;
        }

        private void BindOrderToGrid()
        {
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataTable ds = new DataTable();
            conn.Open();
            dataadapter.Fill(ds);
            conn.Close();
            dg_Order.DataSource = ds;
        }
        
        private void dg_Coffee_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_Coffee.SelectedCells.Count > 0)
            {
                int selectedrowindex = dg_Coffee.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dg_Coffee.Rows[selectedrowindex];

                txt_Name.Text = Convert.ToString(selectedRow.Cells[0].Value);
                txt_Type.Text = Convert.ToString(selectedRow.Cells[1].Value);
                txt_Origin.Text = Convert.ToString(selectedRow.Cells[2].Value);
                txt_Strength.Text = Convert.ToString(selectedRow.Cells[3].Value);
                txt_Quantity.Text = Convert.ToString(selectedRow.Cells[5].Value);

                //Edit Coffee Tab
                txt_EditName.Text = Convert.ToString(selectedRow.Cells[0].Value);
                txt_EditType.Text = Convert.ToString(selectedRow.Cells[1].Value);
                txt_EditOrigin.Text = Convert.ToString(selectedRow.Cells[2].Value);
                txt_EditStrength.Text = Convert.ToString(selectedRow.Cells[3].Value);
                txt_EditPrice.Text = Convert.ToString(selectedRow.Cells[4].Value);
                txt_EditQuantity.Text = Convert.ToString(selectedRow.Cells[5].Value);
                //pb_EditImage.Text = Convert.ToString(selectedRow.Cells[6].Value);
                txt_EditDesc.Text = Convert.ToString(selectedRow.Cells[7].Value);
                ID = Convert.ToInt32(selectedRow.Cells[8].Value);


                if (!Convert.IsDBNull(selectedRow.Cells[6].Value))
                {
                    //byte[] MyData = new byte[0];
                    byte[] MyData = (byte[])selectedRow.Cells[6].Value;
                    //MyData = selectedRow.Cells[6].Value;
                    MemoryStream str = new MemoryStream(MyData);
                    pb_EditImage.Image = Image.FromStream(str);
                    pb_Image.Image = Image.FromStream(str);
                }
                
            }
        }

        private void btn_EditCoffee_Click(object sender, EventArgs e)
        {
            //Image
            FileStream fsl = new FileStream(txt_editCoffeeImage.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            byte[] image = new byte[fsl.Length];
            fsl.Read(image, 0, Convert.ToInt32(fsl.Length));
            fsl.Close();

            //SqlCommand updateDetails = new SqlCommand("UPDATE Coffee SET CoffeeName='@CoffeeName', CoffeeType='" + txt_EditType.Text + "', CoffeeOrigin='" + txt_EditOrigin.Text + "', CoffeeStrength='" + txt_EditStrength.Text + "', CoffeePrice='" + txt_EditPrice.Text + "', CoffeeQuantity='" + txt_EditQuantity.Text + "', CoffeeDesc='" + txt_EditDesc.Text + "' WHERE CoffeeId = " + ID +";", conn);
            SqlCommand updateDetails = new SqlCommand("UPDATE Coffee SET CoffeeName=@CoffeeName, CoffeeType=@CoffeeType, CoffeeOrigin=@CoffeeOrigin, CoffeeStrength=@CoffeeStrength, CoffeePrice=@CoffeePrice, CoffeeQuantity=@CoffeeQuantity, CoffeeDesc=@CoffeeDesc, CoffeeImage=@CoffeeImage WHERE CoffeeId=@CoffeeID;", conn);

            //Also, to avoid SQL Injection, parameterized queries were used, rather than string concatenation.
            updateDetails.Parameters.Add(new SqlParameter("@CoffeeName", txt_EditName.Text));
            updateDetails.Parameters.Add(new SqlParameter("@CoffeeType", txt_EditType.Text));
            updateDetails.Parameters.Add(new SqlParameter("@CoffeeOrigin", txt_EditOrigin.Text));
            updateDetails.Parameters.Add(new SqlParameter("@CoffeeStrength", txt_EditStrength.Text));
            updateDetails.Parameters.Add(new SqlParameter("@CoffeePrice", txt_EditPrice.Text));
            updateDetails.Parameters.Add(new SqlParameter("@CoffeeQuantity", txt_EditQuantity.Text));
            updateDetails.Parameters.Add(new SqlParameter("@CoffeeDesc", txt_EditDesc.Text));
            updateDetails.Parameters.Add(new SqlParameter("@CoffeeID", ID));
            updateDetails.Parameters.Add(new SqlParameter("@CoffeeImage", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image));



            DialogResult dialogResult = MessageBox.Show("Update Coffee '" + txt_Name.Text + "'?", "Edit Coffee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                updateDetails.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Coffee Details Updated");
                sql = "SELECT CoffeeName AS [Name], CoffeeType AS [Type], CoffeeOrigin AS [Origin], CoffeeStrength AS [Strength], CoffeePrice AS [Price], CoffeeQuantity AS [Quantity], CoffeeImage, CoffeeDesc, CoffeeId  FROM Coffee";
                BindDataToGrid();
                MainControlTab.SelectedTab = HomePage;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //SqlCommand updateDetails = new SqlCommand("UPDATE Coffee SET CoffeeName='@CoffeeName', CoffeeType='" + txt_EditType.Text + "', CoffeeOrigin='" + txt_EditOrigin.Text + "', CoffeeStrength='" + txt_EditStrength.Text + "', CoffeePrice='" + txt_EditPrice.Text + "', CoffeeQuantity='" + txt_EditQuantity.Text + "', CoffeeDesc='" + txt_EditDesc.Text + "' WHERE CoffeeId = " + ID +";", conn);
            SqlCommand updateDetails = new SqlCommand("UPDATE Coffee SET CoffeeQuantity=@CoffeeQuantity WHERE CoffeeId=@CoffeeID;", conn);

            //Also, to avoid SQL Injection, parameterized queries were used, rather than string concatenation. 
            updateDetails.Parameters.Add(new SqlParameter("@CoffeeQuantity", txt_Quantity.Text));
            updateDetails.Parameters.Add(new SqlParameter("@CoffeeID", ID));

            DialogResult dialogResult = MessageBox.Show("Stock Coffee '" + txt_Name.Text + "' with " + txt_Quantity.Text + " Quantity?", "Stock Coffee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                UpdateCustomer();
                conn.Open();
                updateDetails.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Coffee has been stocked up");
                sql = "SELECT CoffeeName AS [Name], CoffeeType AS [Type], CoffeeOrigin AS [Origin], CoffeeStrength AS [Strength], CoffeePrice AS [Price], CoffeeQuantity AS [Quantity], CoffeeImage, CoffeeDesc, CoffeeId FROM Coffee";
                BindDataToGrid();
                MainControlTab.SelectedTab = HomePage;
                
            }
        }

        private void UpdateCustomer()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT EmailAddress FROM UpdateEmail WHERE CoffeeID = " + ID + ";";
                cmd.Connection = conn;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    //DataTable dt2 = new DataTable();
                    //sda.Fill(dt2);
                    conn.Close();
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        using (MailMessage mm = new MailMessage("SDIAF1415@gmail.com", sdr["EmailAddress"].ToString()))
                        {
                            mm.Subject = "Good Day Coffee Update";
                            string body = "Hello " + sdr["EmailAddress"].ToString().Trim() + ",";
                            body += "<br /><br />Note: This is an auto-generated message. Please do not respond to it!";
                            body += "<br /><br /> <b>Your coffee has been updated.</b>";
                            body += "<br /> Coffee Name: " + txt_Name.Text;
                            body += "<br /><br /> We look forward to seeing you!";
                            body += "<br /> <b> Good Day Coffee </b>";
                            mm.Body = body;
                            mm.IsBodyHtml = true;
                            SmtpClient smtp = new SmtpClient();
                            smtp.Host = "smtp.gmail.com";
                            smtp.EnableSsl = true;
                            NetworkCredential NetworkCred = new NetworkCredential("SDIAF1415@gmail.com", "Software1415");
                            smtp.UseDefaultCredentials = true;
                            smtp.Credentials = NetworkCred;
                            smtp.Port = 587;
                            smtp.Send(mm);
                        }
                    }
                    conn.Close();
                }
            }
            SqlCommand deleteRecord = new SqlCommand("DELETE FROM UpdateEmail WHERE CoffeeID=" + ID + ";", conn);
            
             conn.Open();
             deleteRecord.ExecuteNonQuery();
             conn.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Image
            FileStream fsl = new FileStream(txt_CoffeeImage.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            byte[] image = new byte[fsl.Length];
            fsl.Read(image, 0, Convert.ToInt32(fsl.Length));
            fsl.Close();

            SqlCommand addRecord = new SqlCommand("INSERT INTO Coffee (CoffeeName, CoffeeType, CoffeeOrigin, CoffeeStrength, CoffeePrice, CoffeeQuantity, CoffeeDesc, CoffeeImage) VALUES (@CoffeeName, @CoffeeType, @CoffeeOrigin, @CoffeeStrength, @CoffeePrice, @CoffeeQuantity, @CoffeeDesc, @CoffeeImage)", conn);

            //Also, to avoid SQL Injection, parameterized queries were used, rather than string concatenation.
            addRecord.Parameters.Add(new SqlParameter("@CoffeeName", txt_AddName.Text));
            addRecord.Parameters.Add(new SqlParameter("@CoffeeType", txt_AddType.Text));
            addRecord.Parameters.Add(new SqlParameter("@CoffeeOrigin", txt_addOrigin.Text));
            addRecord.Parameters.Add(new SqlParameter("@CoffeeStrength", txt_AddStrength.Text));
            addRecord.Parameters.Add(new SqlParameter("@CoffeePrice", txt_AddPrice.Text));
            addRecord.Parameters.Add(new SqlParameter("@CoffeeQuantity", txt_AddQuantity.Text));
            addRecord.Parameters.Add(new SqlParameter("@CoffeeDesc", txt_AddDesc.Text));
            addRecord.Parameters.Add(new SqlParameter("@CoffeeImage", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image));

            DialogResult dialogResult = MessageBox.Show("Add a new coffee '" + txt_AddName.Text + "'?", "New Coffee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                addRecord.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("New Coffee Added");
                sql = "SELECT CoffeeName AS [Name], CoffeeType AS [Type], CoffeeOrigin AS [Origin], CoffeeStrength AS [Strength], CoffeePrice AS [Price], CoffeeQuantity AS [Quantity], CoffeeImage, CoffeeDesc, CoffeeId  FROM Coffee";
                BindDataToGrid();
                MainControlTab.SelectedTab = HomePage;
            }
        }

        private void CheckLowStocks()
        {
            foreach (DataGridViewRow row in dg_Coffee.Rows)
            {
                
                if (Convert.ToInt32(row.Cells["Quantity"].Value) >= 20)
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;

                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Salmon;
                }

            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT CoffeeName AS [Name], CoffeeType AS [Type], CoffeeOrigin AS [Origin], CoffeeStrength AS [Strength], CoffeePrice AS [Price], CoffeeQuantity AS [Quantity], CoffeeImage, CoffeeDesc, CoffeeId  FROM Coffee WHERE CoffeeName LIKE '%" + txt_Search.Text + "%' OR CoffeeType LIKE '%" + txt_Search.Text + "%' OR CoffeeOrigin LIKE '%" + txt_Search.Text + "%'";
            BindDataToGrid();
            CheckLowStocks();
        }

        private void cb_SortBy_SelectedValueChanged(object sender, EventArgs e)
        {
            string sql1 = "SELECT CoffeeName AS [Name], CoffeeType AS [Type], CoffeeOrigin AS [Origin], CoffeeStrength AS [Strength], CoffeePrice AS [Price], CoffeeQuantity AS [Quantity], CoffeeImage, CoffeeDesc, CoffeeId  FROM Coffee WHERE CoffeeName LIKE '%" + txt_Search.Text + "%' OR CoffeeType LIKE '%" + txt_Search.Text + "%' OR CoffeeOrigin LIKE '%" + txt_Search.Text + "%' ";
            string sql2 = "ORDER BY " + cb_SortBy.Text;
            sql = sql1 + sql2;
            BindDataToGrid();

            this.dg_Coffee.Columns[6].Visible = false;
            this.dg_Coffee.Columns[7].Visible = false;
            this.dg_Coffee.Columns[8].Visible = false;

            CheckLowStocks();
        }

        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog picDLG = new OpenFileDialog();
            picDLG.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|(*.*)";
            if (picDLG.ShowDialog() == DialogResult.OK)
            {
                imageFile = picDLG.FileName.ToString();
                pb_AddImage.ImageLocation = imageFile;
                txt_CoffeeImage.Text = imageFile;
            }
        }

        private void btn_EditImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog picDLG = new OpenFileDialog();
            picDLG.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|(*.*)";
            if (picDLG.ShowDialog() == DialogResult.OK)
            {
                imageFile = picDLG.FileName.ToString();
                pb_EditImage.ImageLocation = imageFile;
                txt_editCoffeeImage.Text = imageFile;
            }
        }

        private void dg_Coffee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ////byte[] MyData = new byte[0];
            //byte[] MyData = (byte[])dg_Coffee.CurrentRow.Cells[6].Value;
            ////MyData = selectedRow.Cells[6].Value;
            //MemoryStream str = new MemoryStream(MyData);
            //pb_EditImage.Image = Image.FromStream(str);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteRecord = new SqlCommand("DELETE FROM Coffee WHERE CoffeeId=" + ID + ";", conn);
            DialogResult dialogResult = MessageBox.Show("Permanently delete " + txt_Name.Text + "?", "Delete Authorisation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                deleteRecord.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Coffee has been deleted");
                sql = "SELECT CoffeeName AS [Name], CoffeeType AS [Type], CoffeeOrigin AS [Origin], CoffeeStrength AS [Strength], CoffeePrice AS [Price], CoffeeQuantity AS [Quantity], CoffeeImage, CoffeeDesc, CoffeeId FROM Coffee";
                BindDataToGrid();
                MainControlTab.SelectedTab = HomePage;
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            if (dg_Coffee.Rows.Count > 0)
                index = dg_Coffee.SelectedRows[0].Index;

            sql = "SELECT CoffeeName AS [Name], CoffeeType AS [Type], CoffeeOrigin AS [Origin], CoffeeStrength AS [Strength], CoffeePrice AS [Price], CoffeeQuantity AS [Quantity], CoffeeImage, CoffeeDesc, CoffeeId  FROM Coffee";
            BindDataToGrid();

            this.dg_Coffee.Columns[6].Visible = false;
            this.dg_Coffee.Columns[7].Visible = false;
            this.dg_Coffee.Columns[8].Visible = false;

            CheckLowStocks();

            if (index != -1) //if index == -1 then you don't have rows in your datagrid
            {
                dg_Coffee.Rows[index].Selected = true;
            }
            
        }

        private void CheckStocks()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Coffee WHERE CoffeeQuantity < 20", conn);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                    MessageBox.Show("Please update stocks of " + dt.Rows[0]["CoffeeName"] + ".");
               
            }
        }

        private void timerStockUpdate_Tick(object sender, EventArgs e)
        {
            CheckStocks();
        }

        private void dg_Order_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_Order.SelectedCells.Count > 0)
            {
                int selectedrowindex = dg_Order.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dg_Order.Rows[selectedrowindex];

                txt_OrderNo.Text = Convert.ToString(selectedRow.Cells[0].Value);
                txt_customerName.Text = Convert.ToString(selectedRow.Cells["FirstName"].Value) + " " + Convert.ToString(selectedRow.Cells["LastName"].Value);
                cb_OrderStatus.Text = Convert.ToString(selectedRow.Cells["OrderStatus"].Value);
                txt_CustomerStreet.Text = Convert.ToString(selectedRow.Cells["Street"].Value);
                txt_customerPostcode.Text = Convert.ToString(selectedRow.Cells["PostCode"].Value);
                txt_CustomerCounty.Text = Convert.ToString(selectedRow.Cells["County"].Value);
                txt_CustomerCity.Text = Convert.ToString(selectedRow.Cells["Town"].Value);
                txt_CustomerPhone.Text = Convert.ToString(selectedRow.Cells["Phone"].Value);

                BindOrderItemsToGrid();
            }
        }

        private void BindOrderItemsToGrid()
        {
            sql = "SELECT Id as [Item ID], CoffeeID, Grind, Quantity, Total as [Item Total] FROM [OrderItem] WHERE OrderID = " + txt_OrderNo.Text;
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataTable ds = new DataTable();
            conn.Open();
            dataadapter.Fill(ds);
            conn.Close();
            dg_OrderItem.DataSource = ds;
        }

        private void btn_UpdateStatus_Click(object sender, EventArgs e)
        {
            SqlCommand updateDetails = new SqlCommand("UPDATE [Order] SET OrderStatus=@OrderStatus WHERE OrderID=@OrderID;", conn);

            //Also, to avoid SQL Injection, parameterized queries were used, rather than string concatenation. 
            updateDetails.Parameters.Add(new SqlParameter("@OrderStatus", cb_OrderStatus.Text));
            updateDetails.Parameters.Add(new SqlParameter("@OrderID", txt_OrderNo.Text));

            DialogResult dialogResult = MessageBox.Show("Update Order No. '" + txt_OrderNo.Text + "' to " + cb_OrderStatus.Text + "?", "Update Order Status", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                updateDetails.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Order status has been updated.");

                sql = "SELECT * FROM [Order]";
                BindOrderToGrid();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM [Order] WHERE OrderID LIKE '%" + txt_SearchOrder.Text + "' OR OrderStatus LIKE '%" + txt_Search.Text + "' OR Town LIKE '%" + txt_CustomerCity.Text + "' OR County LIKE '%" + txt_CustomerCounty.Text + "'";
            BindOrderToGrid();
        }
    }
}
