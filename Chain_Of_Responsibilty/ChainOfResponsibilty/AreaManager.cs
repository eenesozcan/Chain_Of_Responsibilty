using Chain_Of_Responsibilty.DAL;

namespace Chain_Of_Responsibilty.ChainOfResponsibilty
{
    public class AreaManager:Employee
    {
        Context context = new Context();
        public override void ProcessRequest(Withdraw req)
        {
            if (req.Amount <= 200000)
            {
                ProcessDetail p = new ProcessDetail();
                p.EmployeeName = "Harice Çınarlı";
                p.EmployeeTitle = "Bölge Müdürü";
                p.Description = "Müşterinin talep ettiği tutar Bölge Müdürü tarafından ödendi";
                p.Amount = req.Amount;
                context.ProcessDetails.Add(p);
                context.SaveChanges();
            }
            else
            {
                ProcessDetail p = new ProcessDetail();
                p.EmployeeName = "Harice Çınarlı";
                p.EmployeeTitle = "Bölge Müdürü";
                p.Description = "Müşterinin talep ettiği tutar banka limitleri dışında olduğu için ödeme yapılamadı.";
                p.Amount = req.Amount;
                context.ProcessDetails.Add(p);
                context.SaveChanges();
            }
        }
    }
}
