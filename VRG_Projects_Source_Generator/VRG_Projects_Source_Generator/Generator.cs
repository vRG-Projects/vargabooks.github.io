using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection.Metadata;

namespace VRG_Projects_Source_Generator
{
    public class Generator
    {
        public static Random rnd = new Random();

        public List<double> GetIsbnNumbers()
        {
            List<double> IsbnNumbers = new List<double>();

            StreamReader sr = new StreamReader("\\src\\isbn.txt");

            while(!sr.EndOfStream)
            {
                IsbnNumbers.Add(Convert.ToDouble(sr.ReadLine());
            }
        }


        // authors: author_id, first_name, last_name, birth_date, country_of_birth
        // customers: customer_id, first_name, middle_name, last_name, gender, address_id, email_address, phone_number




        // books: isbn, book_title, date_of_publication, length, list_price, category_id, author_id, publisher_id


        // purchases: purch_row_id, purch_id, store_id, isbn, customer_id, purchase_quantity, purchase_price_per_piece, purchase_date


        // stocks: stock_id, store_id, isbn, quantity

        public void GenerateSourceOfStocksTable(int quantity)
        {

        }

    }
}
