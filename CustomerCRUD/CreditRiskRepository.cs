using CustomerCRUD.Data;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCRUD
{
    public class CreditRiskRepository : IRepository<CreditRisks>
    {
       private AutoLotContext _dbCreditRisk = new AutoLotContext();

        public IEnumerable<CreditRisks> GetAll()
        {
            List<CreditRisks> credito = _dbCreditRisk.creditRisks.ToList();
            return credito;
        }

        public CreditRisks GetValue(int id)
        {
            CreditRisks creditRisk = _dbCreditRisk.creditRisks.Find(id);
            return creditRisk;
        }

        public void Insert(CreditRisks creditRisk)
        {
            CreditRisks creditToAdd = new CreditRisks
            {
                CustomerId = creditRisk.CustomerId, 
                FirstName = creditRisk.FirstName,
                LastName = creditRisk.LastName,
            };
            _dbCreditRisk.Add(creditToAdd);
            _dbCreditRisk.SaveChanges();
        }

        public void Update(CreditRisks credit)
        {
            CreditRisks creditToUpdate = _dbCreditRisk.creditRisks.Find(credit.Id);
            creditToUpdate.CustomerId = credit.CustomerId;
            creditToUpdate.FirstName = credit.FirstName;
           creditToUpdate.LastName = credit.LastName;
           _dbCreditRisk.SaveChanges();
        }
        public void Delete(int id)
        {
            CreditRisks credit = GetValue(id);
            _dbCreditRisk.creditRisks.Remove(credit);
            _dbCreditRisk.SaveChanges();
        }
    }
}
