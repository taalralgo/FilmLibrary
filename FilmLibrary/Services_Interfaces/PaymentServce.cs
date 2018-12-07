using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "PaymentServce" à la fois dans le code et le fichier de configuration.
    public class PaymentServce : IPaymentServce
    {
        DBContext db = new DBContext();
        public int Add(Payment payment)
        {
            try
            {
                db.Payments.Add(payment);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Payment Find(int id)
        {
            try
            {
                return db.Payments.Where(p => p.PaymentId.Equals(id)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Payment> FindAll()
        {
            try
            {
                return db.Payments.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modifier(int id, int montant, int customerid)
        {
            try
            {
                Payment payment = new Payment();
                payment.PaymentAmount = montant;
                payment.CustomerId = customerid;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
