using System;

namespace Perfect.ERP
{
    interface ICUSTOMER
    {
        void AddCombo(System.Windows.Forms.ComboBox combo);
        void AddComboAll(System.Windows.Forms.ComboBox combo);
        string Delete(System.Data.SqlClient.SqlTransaction myTransaction, string Customer_ID);
        string Delete(string Customer_ID);
        string Delete(System.Data.SqlClient.SqlConnection myConnection, string Customer_ID);
        string Delete();
        bool Exist(string Customer_ID);
        string Get(System.Data.SqlClient.SqlTransaction myTransaction, string Customer_ID);
        string Get(string Customer_ID);
        string Get(System.Data.SqlClient.SqlConnection myConnection, string Customer_ID);
        System.Data.DataTable GetList();
        string Insert(System.Data.SqlClient.SqlConnection myConnection, string Customer_ID, long OrderID, string CustomerName, string Customer_Type_ID, string Customer_Group_ID, string CustomerAddress, string Birthday, string Barcode, string Tax, string Tel, string Fax, string Email, string Mobile, string Website, string Contact, string Position, string NickYM, string NickSky, string Area, string District_ID, string National_ID, string City_ID, string BankAccount, string BankName, double CreditLimit, double Discount, string Description, bool Active);
        string Insert();
        string Insert(System.Data.SqlClient.SqlTransaction myTransaction, string Customer_ID, long OrderID, string CustomerName, string Customer_Type_ID, string Customer_Group_ID, string CustomerAddress, string Birthday, string Barcode, string Tax, string Tel, string Fax, string Email, string Mobile, string Website, string Contact, string Position, string NickYM, string NickSky, string Area, string District_ID, string National_ID, string City_ID, string BankAccount, string BankName, double CreditLimit, double Discount, string Description, bool Active);
        string Insert(System.Data.SqlClient.SqlTransaction myTransaction);
        string Insert(string Customer_ID, long OrderID, string CustomerName, string Customer_Type_ID, string Customer_Group_ID, string CustomerAddress, string Birthday, string Barcode, string Tax, string Tel, string Fax, string Email, string Mobile, string Website, string Contact, string Position, string NickYM, string NickSky, string Area, string District_ID, string National_ID, string City_ID, string BankAccount, string BankName, double CreditLimit, double Discount, string Description, bool Active);
        string NewID(string F_Key);
        string NewID();
        string Update();
        string Update(System.Data.SqlClient.SqlTransaction myTransaction, string Customer_ID, long OrderID, string CustomerName, string Customer_Type_ID, string Customer_Group_ID, string CustomerAddress, string Birthday, string Barcode, string Tax, string Tel, string Fax, string Email, string Mobile, string Website, string Contact, string Position, string NickYM, string NickSky, string Area, string District_ID, string National_ID, string City_ID, string BankAccount, string BankName, double CreditLimit, double Discount, string Description, bool Active);
        string Update(System.Data.SqlClient.SqlConnection myConnection, string Customer_ID, long OrderID, string CustomerName, string Customer_Type_ID, string Customer_Group_ID, string CustomerAddress, string Birthday, string Barcode, string Tax, string Tel, string Fax, string Email, string Mobile, string Website, string Contact, string Position, string NickYM, string NickSky, string Area, string District_ID, string National_ID, string City_ID, string BankAccount, string BankName, double CreditLimit, double Discount, string Description, bool Active);
        string Update(string Customer_ID, long OrderID, string CustomerName, string Customer_Type_ID, string Customer_Group_ID, string CustomerAddress, string Birthday, string Barcode, string Tax, string Tel, string Fax, string Email, string Mobile, string Website, string Contact, string Position, string NickYM, string NickSky, string Area, string District_ID, string National_ID, string City_ID, string BankAccount, string BankName, double CreditLimit, double Discount, string Description, bool Active);
    }
}
