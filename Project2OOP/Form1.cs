using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // library for working with files.........IO == INPUTOUTPUT

namespace Project2OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaring Constants
        const int APPLE_PIE = 10;
        const int APPLE_CIDER = 15;
        const int APPLE_CRISP = 12;
        const int APPLE_SAUCE = 8;
        const double priceAPPLE_PIE = 12.50;
        const double priceAPPLE_CIDER = 2.75;
        const double priceAPPLE_CRISP = 9.85;
        const double priceAPPLE_SAUCE = 1.75;
        const double TAX_RATE = 0.0825;

        //Declaring Global Variables
        int intAvailableApples = 100;
        int intApplesRemaining = 100;
        
        //int intInvoiceVariable = 0;
       // int intQuanityAP = 0;
       // int intQuanityAC = 0;
        //int intQuanityACR = 0;
        //int intQuanityAS = 0;
       
        

       
        double dblSubtotalAP = 0.0;
        double dblSubtotalAC = 0.0;
        double dblSubtotalACR = 0.0;
        double dblSubtotalAS = 0.0;
        double dblTaxAP = 0.0;
        double dblTaxAC = 0.0;
        double dblTaxACR = 0.0;
        double dblTaxAS = 0.0;
   
        double dblreceiptSubtotal;
        double dblrecieptTaxTotal;
        double dblrecieptOrderTotal;


       


        string strTimes = " x ";
        string strColon = " ...... ";
        string strDivider = "--------------------------------------------------------------------";
        string strSubtotal = "SubTotal:" + "..........";
        string strAppliedTax = "Applied Tax:" + "..........";
        string strOrderTotal = "Order Total:" + "..........";
        
        
      

       
        //global Arrays
        ApplePieOrder[] applePie = new ApplePieOrder[0];
        AppleCiderOrder[] appleCider = new AppleCiderOrder[0];
        AppleCrispOrder[] appleCrisp = new AppleCrispOrder[0];
        AppleSauceOrder[] appleSauce = new AppleSauceOrder[0];
        
        


          
        struct Invoices
        {

            public int intAPInvoice;
            public int intACInvoice;
            public int intACRInvoice;
            public int intASInvoice;
          
        }
         Invoices[] myInvoice = new Invoices[0]; 
        

        struct ApplePieOrder
        {
            public string strQuanityAP;
            public string strTimesList;
            public string strAppleProductSelected;
            public string strColonList;
            public string strCostPerProductList;
            
            
            
        }

        struct AppleCiderOrder
        {
            public string strQuanityAC;
            public string strTimesList;
            public string strAppleProductSelected;
            public string strColonList;
            public string strCostPerProductList;
            
        }

        struct AppleCrispOrder
        {
            public string strQuanityACR;
            public string strTimesList;
            public string strAppleProductSelected;
            public string strColonList;
            public string strCostPerProductList;
            
        }

        struct AppleSauceOrder
        {
            public string strQuanityAS;
            public string strTimesList;
            public string strAppleProductSelected;
            public string strColonList;
            public string strCostPerProductList;
            
        }

        
        private void DisplayOrder()
        {
           // this method gathers all required informaiton and populates to Reciept listbox
            
            //clearing the output ist
            lstOutput1.Items.Clear();


            //add date and time
            lstOutput1.Items.Add(DateTime.Now);
            lstOutput1.Items.Add("");
            // seeing if apple pie was added

            //if quanity of Apple pies is greater than -1 add apple pies to receipt
            if ((Convert.ToInt32(lblQuanityAP.Text)) > -1)
            {
                for (int intQuanityAP = 0; intQuanityAP < applePie.Length; intQuanityAP++)
                {
                    if (applePie[intQuanityAP].strQuanityAP == (Convert.ToInt32(lblQuanityAP.Text)).ToString())
                    {
                        
                        
                        //adding apple pie values to reciept
                        lstOutput1.Items.Add(applePie[intQuanityAP].strQuanityAP + applePie[intQuanityAP].strTimesList + applePie[intQuanityAP].strAppleProductSelected + applePie[intQuanityAP].strColonList + applePie[intQuanityAP].strCostPerProductList);
                       
                        //calculating apple pie subtotals and tax
                        dblSubtotalAP = (Convert.ToInt32(lblQuanityAP.Text) * priceAPPLE_PIE);
                        dblTaxAP = (Convert.ToInt32(lblQuanityAP.Text) * priceAPPLE_PIE) * TAX_RATE;

                        
                        
                    }
                }
            }

            //if quanity of apple cider is greater than -1 then add apple ciders to reciept
            
            if ((Convert.ToInt32(lblQuanityAC.Text)) > -1)
            {
                for (int intQuanityAC = 0; intQuanityAC < appleCider.Length; intQuanityAC++)
                {
                    if (appleCider[intQuanityAC].strQuanityAC == (Convert.ToInt32(lblQuanityAC.Text).ToString()))
                    {
                        //adding apple cider values to reciept
                        lstOutput1.Items.Add(appleCider[intQuanityAC].strQuanityAC + appleCider[intQuanityAC].strTimesList + appleCider[intQuanityAC].strAppleProductSelected + appleCider[intQuanityAC].strColonList + appleCider[intQuanityAC].strCostPerProductList);
                        
                        //calculating apple cider subtotal and amount of tax
                        dblSubtotalAC = (Convert.ToInt32(lblQuanityAC.Text) * priceAPPLE_CIDER);
                        dblTaxAC = (Convert.ToInt32(lblQuanityAC.Text) * priceAPPLE_CIDER) * TAX_RATE;
                    }
                }
            }

            //if quanity of Apple crisps is greater than -1 then add apple ciders to reciept
            if ((Convert.ToInt32(lblQuanityACR.Text)) > -1)
            {
                for (int intQuanityACR = 0; intQuanityACR < appleCrisp.Length; intQuanityACR++)
                {
                    if (appleCrisp[intQuanityACR].strQuanityACR == (Convert.ToInt32(lblQuanityACR.Text).ToString()))
                    {
                        // adding apple crisp values to reciept
                        lstOutput1.Items.Add(appleCrisp[intQuanityACR].strQuanityACR + appleCrisp[intQuanityACR].strTimesList + appleCrisp[intQuanityACR].strAppleProductSelected + appleCrisp[intQuanityACR].strColonList + appleCrisp[intQuanityACR].strCostPerProductList);
                        
                        //calculating subtotal for apple crisp and amount of tax
                        dblSubtotalACR = (Convert.ToInt32(lblQuanityACR.Text) * priceAPPLE_CRISP);
                        dblTaxACR = (Convert.ToInt32(lblQuanityACR.Text) * priceAPPLE_CRISP) * TAX_RATE;
                    }
                }
            }

            //if quanity of Apple sauces is greater than -1 thn add to the reciept
            if ((Convert.ToInt32(lblQuanityAS.Text))  > -1)
            {
                for (int intQuanityAS = 0; intQuanityAS < appleSauce.Length; intQuanityAS++)
                {
                    if (appleSauce[intQuanityAS].strQuanityAS == (Convert.ToInt32(lblQuanityAS.Text).ToString()))
                    {
                        //adding the apple sauce values to the rciept
                        lstOutput1.Items.Add(appleSauce[intQuanityAS].strQuanityAS + appleSauce[intQuanityAS].strTimesList + appleSauce[intQuanityAS].strAppleProductSelected + appleSauce[intQuanityAS].strColonList + appleSauce[intQuanityAS].strCostPerProductList);
                       
                        //calculating the subtotal for apple sauces and the amount of tax
                        dblSubtotalAS = (Convert.ToInt32(lblQuanityAS.Text) * priceAPPLE_SAUCE);
                        dblTaxAS = (Convert.ToInt32(lblQuanityAS.Text) * priceAPPLE_SAUCE) * TAX_RATE;
                    }
                }
            }
           
            //declaring variables that calulate overall reciept subtotal, taxtotal, and final order total
            dblreceiptSubtotal = dblSubtotalAC + dblSubtotalAP + dblSubtotalACR + dblSubtotalAS;
            dblrecieptTaxTotal = dblTaxAP + dblTaxAC + dblTaxACR + dblTaxAS;
            dblrecieptOrderTotal = (dblSubtotalAP + dblTaxAP) + (dblSubtotalAC + dblTaxAC) + (dblSubtotalACR + dblTaxACR) + (dblSubtotalAS + dblTaxAS);
            
            //adding variables to Reciept list
            lstOutput1.Items.Add(strDivider);
            lstOutput1.Items.Add(strSubtotal + (dblreceiptSubtotal.ToString("c")));
            lstOutput1.Items.Add(strAppliedTax + (dblrecieptTaxTotal).ToString("c"));
            lstOutput1.Items.Add(strOrderTotal + (dblrecieptOrderTotal).ToString("c"));
            

           
        }
      
     
        private void CheckQuanity()
        {
            //are there enough apples for product?..if so, enable plus button
            if (Convert.ToInt32(lblApplesRemaining.Text) < APPLE_PIE)
            {
                btnAddAP.Enabled = false;
            }
             if (Convert.ToInt32(lblApplesRemaining.Text) >= APPLE_PIE)
            {
                btnAddAP.Enabled = true;
            }
            if (Convert.ToInt32(lblApplesRemaining.Text) < APPLE_CIDER)
            {
                btnAddAC.Enabled = false;
            }

            if ((Convert.ToInt32(lblApplesRemaining.Text) >= APPLE_CIDER))
            {
                btnAddAC.Enabled = true;
            }
            if (Convert.ToInt32(lblApplesRemaining.Text) < APPLE_CRISP)
            {
                btnAddACR.Enabled = false;
            }
             if (Convert.ToInt32(lblApplesRemaining.Text) >= APPLE_CRISP)
            {
                btnAddACR.Enabled = true;
            }
            if (Convert.ToInt32(lblApplesRemaining.Text) < APPLE_SAUCE)
            {
                btnAddAS.Enabled = false;
            }
            if (Convert.ToInt32(lblApplesRemaining.Text) >= APPLE_SAUCE)
            {
                btnAddAS.Enabled = true;
            }
            
            //have apples been added?... if so enable minus button
           
            //if no apples have been added then disable minus but to prevent neg values
            if (Convert.ToInt32(lblQuanityAP.Text) == 0)
            {
                btnMinusAP.Enabled = false;
            }
            // if no apples added disable minus button to prevent neg numberrs
            if (Convert.ToInt32(lblQuanityAC.Text) == 0)
            {
                btnMinusAC.Enabled = false;
            }
            //if no apples added disable minus button
            if (Convert.ToInt32(lblQuanityACR.Text) == 0)
            {
                btnMinusACR.Enabled = false;
            }
            //if no apples disable
            if (Convert.ToInt32(lblQuanityAS.Text) == 0)
            {
                btnMinusAS.Enabled = false;
            }
            
            //checking to see if apples are sufficent
            if(Convert.ToInt32(lblApplesRemaining.Text) < APPLE_SAUCE)
            {
                lblNo.Enabled = true;
                lblYes.Enabled = false;
                lblNoMoreItems.Visible = true;

            }
            else
            {
                lblYes.Enabled = true;
                lblNo.Enabled = false;
                lblNoMoreItems.Visible = false;
            }
        }
       

        private void btnAddAP_Click(object sender, EventArgs e)
        {
            //reading in values for added apple pies
            string strAppleProductInput1 = lblApplePie.Text;
            double dblProductInputPrice1 = ((Convert.ToInt32(lblQuanityAP.Text) + 1)) * priceAPPLE_PIE;
            lblQuanityAP.Text = ((Convert.ToInt32(lblQuanityAP.Text)) + 1).ToString();
            int intQuanityAP = (Convert.ToInt32(lblQuanityAP.Text));
            double dblFinalSubtotal = (dblSubtotalAC + dblSubtotalAP + dblSubtotalACR + dblSubtotalAS);
            
            //if quanity of apple pies is greater than -1 add to array
            if((Convert.ToInt32(lblQuanityAP.Text)) > -1)
            {
                //expand array 
                Array.Resize(ref applePie, applePie.Length + 1);
                //add values to array
                applePie[applePie.Length - 1].strQuanityAP = (Convert.ToInt32(lblQuanityAP.Text)).ToString();
                applePie[applePie.Length - 1].strTimesList = strTimes;
                applePie[applePie.Length - 1].strAppleProductSelected = strAppleProductInput1;
                applePie[applePie.Length - 1].strColonList = strColon;
                applePie[applePie.Length - 1].strCostPerProductList = dblProductInputPrice1.ToString("c");

                //display output
                //insert code here
                DisplayOrder();
            }

            
          
             //if quanity is valid remove from remaining apples
             if ((Convert.ToInt32(lblQuanityAP.Text) > -1))
             {
                 lblApplesRemaining.Text = ((Convert.ToInt32(lblApplesRemaining.Text)) - APPLE_PIE).ToString();


                 // enable minus button when quanity is greater than 0
                 btnMinusAP.Enabled = true;
             }
           

            CheckQuanity();
        }

        private void btnMinusAP_Click(object sender, EventArgs e)
        {
            //reading in values for added apple pies
           
            lblQuanityAP.Text = ((Convert.ToInt32(lblQuanityAP.Text)) - 1).ToString();
            dblSubtotalAP = 0.0;
            dblTaxAP = 0.0;

            

            if (Convert.ToInt32(lblQuanityAP.Text) > -1)
            {
                //remove from  array 
                Array.Resize(ref applePie, applePie.Length - 1);
             
                DisplayOrder();
            }
            //adding apples back to stock
            if (Convert.ToInt32(lblQuanityAP.Text) > -1)
            {
                
                lblApplesRemaining.Text = ((Convert.ToInt32(lblApplesRemaining.Text)) + APPLE_PIE).ToString();
            }

            //checking quanity to specify what buttons are available
            CheckQuanity();
           
        }

        private void btnAddAC_Click(object sender, EventArgs e)
        {
            //reading in values for added apple Ciders
            string strAppleProductInput2 = lblAppleCider.Text;
            double dblProductInputPrice2 = ((Convert.ToInt32(lblQuanityAC.Text) + 1)) * priceAPPLE_CIDER;
            lblQuanityAC.Text = ((Convert.ToInt32(lblQuanityAC.Text)) + 1).ToString();
            
            

            //if apple cider quanity is greater than -1 then add to array
            if ((Convert.ToInt32(lblQuanityAC.Text) + 1) > -1)
            {
                //expand array 
                Array.Resize(ref appleCider, appleCider.Length + 1);
                //add values to array
                appleCider[appleCider.Length - 1].strQuanityAC = (Convert.ToInt32(lblQuanityAC.Text)).ToString();
                appleCider[appleCider.Length - 1].strTimesList = strTimes;
                appleCider[appleCider.Length - 1].strAppleProductSelected = strAppleProductInput2;
                appleCider[appleCider.Length - 1].strColonList = strColon;
                appleCider[appleCider.Length - 1].strCostPerProductList = dblProductInputPrice2.ToString("c");

                //display output
                //insert code here
                DisplayOrder();
            }

            //if quanity is valid remove from remaining apples
            if ((Convert.ToInt32(lblQuanityAC.Text) > -1))
            {
                lblApplesRemaining.Text = ((Convert.ToInt32(lblApplesRemaining.Text)) - APPLE_CIDER).ToString();
              btnMinusAC.Enabled = true;
            }

            //are there enough apples for Apple Cider?
            CheckQuanity();
           
        }

        private void btnMinusAC_Click(object sender, EventArgs e)
        {
            //reading in values for added apple pies

            lblQuanityAC.Text = ((Convert.ToInt32(lblQuanityAC.Text)) - 1).ToString();
            dblSubtotalAC = 0.0;
            dblTaxAC = 0.0;


            if (Convert.ToInt32(lblQuanityAC.Text) > -1)
            {
                //remove from  array 
                Array.Resize(ref appleCider, appleCider.Length - 1);

                DisplayOrder();
            }
            //add apples back to stock
            if (Convert.ToInt32(lblQuanityAC.Text) > -1)
            {

                lblApplesRemaining.Text = ((Convert.ToInt32(lblApplesRemaining.Text)) + APPLE_CIDER).ToString();
            }
            
            // if there are enough apples to create apple cider eneable add button
            CheckQuanity();
        }

        private void btnAddACR_Click(object sender, EventArgs e)
        {
            //reading in values for added apple pies
            string strAppleProductInput3 = lblAppleCrisp.Text;
            double dblProductInputPrice3 = ((Convert.ToInt32(lblQuanityACR.Text) + 1)) * priceAPPLE_CRISP;
            lblQuanityACR.Text = ((Convert.ToInt32(lblQuanityACR.Text)) + 1).ToString();


            if ((Convert.ToInt32(lblQuanityACR.Text) + 1) > -1)
            {
                //expand array 
                Array.Resize(ref appleCrisp, appleCrisp.Length + 1);
                //add values to array
                appleCrisp[appleCrisp.Length - 1].strQuanityACR = (Convert.ToInt32(lblQuanityACR.Text)).ToString();
                appleCrisp[appleCrisp.Length - 1].strTimesList = strTimes;
                appleCrisp[appleCrisp.Length - 1].strAppleProductSelected = strAppleProductInput3;
                appleCrisp[appleCrisp.Length - 1].strColonList = strColon;
                appleCrisp[appleCrisp.Length - 1].strCostPerProductList = dblProductInputPrice3.ToString("c");

                //display output
                //insert code here
                DisplayOrder();
            }

            //if quanity is valid remove from remaining apples
            if ((Convert.ToInt32(lblQuanityACR.Text) > -1))
            {
                lblApplesRemaining.Text = ((Convert.ToInt32(lblApplesRemaining.Text)) - APPLE_CRISP).ToString();
                btnMinusACR.Enabled = true;
            }
            //checking quanity to determine which buttons enables
            CheckQuanity();
            
        }

        private void btnMinusACR_Click(object sender, EventArgs e)
        {
            //reading in values for added apple pies

            lblQuanityACR.Text = ((Convert.ToInt32(lblQuanityACR.Text)) - 1).ToString();
            dblSubtotalACR = 0.0;
            dblTaxACR = 0.0;


            if (Convert.ToInt32(lblQuanityACR.Text) > -1)
            {
                //remove from  array 
                Array.Resize(ref appleCrisp, appleCrisp.Length - 1);

                DisplayOrder();
            }

            if (Convert.ToInt32(lblQuanityACR.Text) > -1)
            {
                lblApplesRemaining.Text = ((Convert.ToInt32(lblApplesRemaining.Text)) + APPLE_CRISP).ToString();
            }

            CheckQuanity();
        }

        private void btnAddAS_Click(object sender, EventArgs e)
        
        
        {
            //reading in values for added apple pies
            string strAppleProductInput4 = lblAppleSauce.Text;
            double dblProductInputPrice4 = ((Convert.ToInt32(lblQuanityAS.Text) + 1)) * priceAPPLE_SAUCE;
            lblQuanityAS.Text = ((Convert.ToInt32(lblQuanityAS.Text)) + 1).ToString();


            if ((Convert.ToInt32(lblQuanityAS.Text) + 1) > -1)
            {
                //expand array 
                Array.Resize(ref appleSauce, appleSauce.Length + 1);
                //add values to array
                appleSauce[appleSauce.Length - 1].strQuanityAS = (Convert.ToInt32(lblQuanityAS.Text)).ToString();
                appleSauce[appleSauce.Length - 1].strTimesList = strTimes;
                appleSauce[appleSauce.Length - 1].strAppleProductSelected = strAppleProductInput4;
                appleSauce[appleSauce.Length - 1].strColonList = strColon;
                appleSauce[appleSauce.Length - 1].strCostPerProductList = dblProductInputPrice4.ToString("c");

                //display output
                //insert code here
                DisplayOrder();
            }

            //if quanity is valid remove from remaining apples
            if ((Convert.ToInt32(lblQuanityAS.Text) > -1))
            {
                lblApplesRemaining.Text = ((Convert.ToInt32(lblApplesRemaining.Text)) - APPLE_SAUCE).ToString();
                btnMinusAS.Enabled = true;
            }

            CheckQuanity();
            
        }




        private void btnMinusAS_Click(object sender, EventArgs e)
        {
            //reading in values for added apple pies
           
            lblQuanityAS.Text = ((Convert.ToInt32(lblQuanityAS.Text)) - 1).ToString();
            dblSubtotalAS = 0.0;
            dblTaxAS = 0.0;


            if (Convert.ToInt32(lblQuanityAS.Text) > -1)
            {
                //remove from  array 
                Array.Resize(ref appleSauce, appleSauce.Length - 1);
                

                DisplayOrder();
            }

            if (Convert.ToInt32(lblQuanityAS.Text) > -1)
            {
                lblApplesRemaining.Text = ((Convert.ToInt32(lblApplesRemaining.Text)) + APPLE_SAUCE).ToString();
            }

            CheckQuanity();
        }

        

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //reset everything
            lstOutput1.Items.Clear();

            // Converting NumericUpDown to integar to do calculations
            int intApplePieCount = Convert.ToInt32(lblQuanityAP.Text.ToString());
            int intAppleCiderCount = Convert.ToInt32(lblQuanityAC.Text.ToString());
            int intAppleCrispCount = Convert.ToInt32(lblQuanityACR.Text.ToString());
            int intAppleSauceCount = Convert.ToInt32(lblQuanityAS.Text.ToString());

            // Reading in values
            int intPieInvoiceInput = intApplePieCount;
            int intCiderInvoiceInput = intAppleCiderCount;
            int intCrispInvoiceInput = intAppleCrispCount;
            int intSauceInvoiceInput = intAppleSauceCount;

            // Expand the array
            Array.Resize(ref myInvoice, myInvoice.Length + 1);

            // Add values from user to array
            myInvoice[myInvoice.Length - 1].intAPInvoice = intPieInvoiceInput;
            myInvoice[myInvoice.Length - 1].intACInvoice = intCiderInvoiceInput;
            myInvoice[myInvoice.Length - 1].intACRInvoice = intCrispInvoiceInput;
            myInvoice[myInvoice.Length - 1].intASInvoice = intSauceInvoiceInput;

            lstOutput2.Items.Clear();
            DisplayInvoices();


            //reset everything
            lstOutput1.Items.Clear();
            lstOutput3.Items.Clear();

                //intQuanityAP = 0;
                lblQuanityAP.Text = "0"; //intQuanityAP.ToString();

                // intQuanityAC = 0;
                lblQuanityAC.Text = "0";//intQuanityAC.ToString();

                // intQuanityACR = 0;
                lblQuanityACR.Text = "0";//intQuanityACR.ToString();

                //intQuanityAS = 0;
                lblQuanityAS.Text = "0";//intQuanityAS.ToString();

               //resetting the totals
                dblSubtotalAP = 0.0;
                dblSubtotalAC = 0.0;
                dblSubtotalACR = 0.0;
                dblSubtotalAS = 0.0;
                dblTaxAP = 0.0;
                dblTaxAC = 0.0;
                dblTaxACR = 0.0;
                dblTaxAS = 0.0;
                
            //disabling the minus buttons
                btnMinusAP.Enabled = false;
                btnMinusAC.Enabled = false;
                btnMinusACR.Enabled = false;
                btnMinusAS.Enabled = false;
            //updating inventory
                intAvailableApples = Convert.ToInt32(lblApplesRemaining.Text);
                lblAppleInventory.Text = intAvailableApples.ToString();

                
            
         
           
        }
        private void DisplayInvoices()
        {
            //adding invoices to historical orders
            lstOutput2.Items.Clear();
            for (int intInvoiceVariable = 0; intInvoiceVariable < myInvoice.Length; intInvoiceVariable++)
            {
                
                lstOutput2.Items.Add("Invoice" +"" +  intInvoiceVariable.ToString());
                
            }
        }
        private void lstOutput3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAddToInventory_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Reading in the apples to add to the inventory.
                    intAvailableApples += Convert.ToInt32(txtInput.Text);
                    intApplesRemaining = intAvailableApples;

                    // Outputting the number of apples on hand.
                    lblAppleInventory.Text = intAvailableApples.ToString();
                    lblApplesRemaining.Text = intApplesRemaining.ToString();

                    // Resetting input to 0
                    txtInput.Text = "0";
                }
                //make sure vaild numbers were entered.
                catch (FormatException)
                {
                    MessageBox.Show("Please enter vailid quanity");
                    // Resetting input to 0
                    txtInput.Text = "0";
                }

                //update buttons
                CheckQuanity();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set default filter for open/save dialogs
            openFileDialog1.Filter = "Text Files |*.txt|All Files|*.*";
            saveFileDialog1.Filter = "Text Files |*.txt|All Files|*.*";

            //setting default extenstion

            openFileDialog1.DefaultExt = "txt";
            saveFileDialog1.DefaultExt = "txt"; 
        }

    

        private void txtClearAll_Click(object sender, EventArgs e)
        {
            //this button will reset the form incase an order is canceled before it is placed
            //reset everything
            lstOutput1.Items.Clear();
            //intQuanityAP = 0;
            lblQuanityAP.Text = "0"; //intQuanityAP.ToString();

            // intQuanityAC = 0;
            lblQuanityAC.Text = "0";//intQuanityAC.ToString();

            // intQuanityACR = 0;
            lblQuanityACR.Text = "0";//intQuanityACR.ToString();

            //intQuanityAS = 0;
            lblQuanityAS.Text = "0";//intQuanityAS.ToString();

            //resetiing all totals
            dblSubtotalAP = 0.0;
            dblSubtotalAC = 0.0;
            dblSubtotalACR = 0.0;
            dblSubtotalAS = 0.0;
            dblTaxAP = 0.0;
            dblTaxAC = 0.0;
            dblTaxACR = 0.0;
            dblTaxAS = 0.0;
     
            //disabling the minus buttons
            btnMinusAP.Enabled = false;
            btnMinusAC.Enabled = false;
            btnMinusACR.Enabled = false;
            btnMinusAS.Enabled = false;

            intApplesRemaining = intAvailableApples;
            lblApplesRemaining.Text = lblAppleInventory.Text;
        }

        private void lstOutput2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // this method gathers all required informaiton and populates to Reciept listbox

            //clearing the output ist
            lstOutput3.Items.Clear();


            //add date and time
            lstOutput3.Items.Add(DateTime.Now);
            lstOutput3.Items.Add("");
            // seeing if apple pie was added

            //if quanity of Apple pies is greater than -1 add apple pies to receipt
            if (lstOutput2.SelectedIndex < myInvoice.Length)
            {
                
                for (int intAPInvoice = 0; intAPInvoice < myInvoice.Length; intAPInvoice++)
                {

                    if (myInvoice[intAPInvoice].intAPInvoice > -1)
                    {
                        //adding apple pie values to reciept

                        lstOutput3.Items.Add(myInvoice[intAPInvoice].intAPInvoice.ToString() + "" + strTimes + lblApplePie.Text + strColon + (myInvoice[intAPInvoice].intAPInvoice * priceAPPLE_PIE).ToString("c"));

                        //calculating apple pie subtotals and tax
                        dblSubtotalAP = (myInvoice[intAPInvoice].intAPInvoice * priceAPPLE_PIE);
                        dblTaxAP = (myInvoice[intAPInvoice].intAPInvoice * priceAPPLE_PIE) * TAX_RATE;



                    }

                }
                if (lstOutput2.SelectedIndex > -1)
                {
                    
                    for (int intACVariable = 0; intACVariable < myInvoice.Length; intACVariable++)
                    {
                        if (myInvoice[intACVariable].intACInvoice > -1)
                        {
                            //adding apple pie values to reciept

                            lstOutput3.Items.Add(myInvoice[intACVariable].intACInvoice.ToString() + "" + strTimes + lblAppleCider.Text + strColon + (myInvoice[intACVariable].intACInvoice * priceAPPLE_CIDER).ToString("c"));

                            //calculating apple pie subtotals and tax
                            dblSubtotalAC = (myInvoice[intACVariable].intACInvoice * priceAPPLE_CIDER);
                            dblTaxAC = (myInvoice[intACVariable].intACInvoice * priceAPPLE_CIDER) * TAX_RATE;

                        }
                    }
                }
                if(lstOutput2.SelectedIndex > -1)
                {
                    for (int intACRVariable = 0; intACRVariable < myInvoice.Length; intACRVariable++)
                    {
                        if (myInvoice[intACRVariable].intACRInvoice > -1)
                        {
                            //adding apple pie values to reciept

                            lstOutput3.Items.Add(myInvoice[intACRVariable].intACRInvoice.ToString() + "" + strTimes + lblAppleCrisp.Text + strColon + (myInvoice[intACRVariable].intACRInvoice * priceAPPLE_CRISP).ToString("c"));

                            //calculating apple pie subtotals and tax
                            dblSubtotalACR = (myInvoice[intACRVariable].intACRInvoice * priceAPPLE_CRISP);
                            dblTaxACR = (myInvoice[intACRVariable].intACRInvoice * priceAPPLE_CRISP) * TAX_RATE;

                        }
                    }
                }

                if (lstOutput2.SelectedIndex > -1)
                {
                    for (int intASVariable = 0; intASVariable < myInvoice.Length; intASVariable++)
                    {
                        if (myInvoice[intASVariable].intASInvoice > -1)
                        {
                            //adding apple pie values to reciept

                            lstOutput3.Items.Add(myInvoice[intASVariable].intASInvoice.ToString() + "" + strTimes + lblAppleSauce.Text + strColon + (myInvoice[intASVariable].intASInvoice * priceAPPLE_SAUCE).ToString("c"));

                            //calculating apple pie subtotals and tax
                            dblSubtotalAS = (myInvoice[intASVariable].intASInvoice * priceAPPLE_SAUCE);
                            dblTaxAS = (myInvoice[intASVariable].intASInvoice * priceAPPLE_SAUCE) * TAX_RATE;

                        }
                    }
                }
                    //declaring variables that calulate overall reciept subtotal, taxtotal, and final order total
                    dblreceiptSubtotal = dblSubtotalAC + dblSubtotalAP + dblSubtotalACR + dblSubtotalAS;
                    dblrecieptTaxTotal = dblTaxAP + dblTaxAC + dblTaxACR + dblTaxAS;
                    dblrecieptOrderTotal = (dblSubtotalAP + dblTaxAP) + (dblSubtotalAC + dblTaxAC) + (dblSubtotalACR + dblTaxACR) + (dblSubtotalAS + dblTaxAS);

                    //adding variables to Reciept list
                    lstOutput3.Items.Add(strDivider);
                    lstOutput3.Items.Add(strSubtotal + (dblreceiptSubtotal.ToString("c")));
                    lstOutput3.Items.Add(strAppliedTax + (dblrecieptTaxTotal).ToString("c"));
                    lstOutput3.Items.Add(strOrderTotal + (dblrecieptOrderTotal).ToString("c"));
                    lstOutput3.Items.Add("------------------------------------------------------------");

                }
            

        }

        

        
    }
}
