using System;
using System.Collections.Generic;
using System.Text;

namespace Open_newApp
{
    public class BankingList
    {
        public List<BankingListModel> get()
        {
            var List = new List<BankingListModel>();
            List.Add(new BankingListModel
            {
                Name = "demo.univerasl.link",
                BundleId = "thes.dev.demouniversallink",
                IdOnAppStore = ""
            });
            List.Add(new BankingListModel
            {
                Name = "kbank.kplus",
                BundleId = "com.kasikorn.retail.mbanking.wap",
                IdOnAppStore = "361170631"
            });
            List.Add(new BankingListModel
            {
                Name = "A-Mobile",
                BundleId = "com.ccpp.baac",
                IdOnAppStore = "1199267294"
            });
            List.Add(new BankingListModel
            {
                Name = "ktbnext",
                BundleId = "ktbcs.netbank",
                IdOnAppStore = "436753378"
            });
            List.Add(new BankingListModel
            {
                Name = "scbeasy",
                BundleId = "com.scb.phone",
                IdOnAppStore = "568388474"
            });
            List.Add(new BankingListModel
            {
                Name = "mymo",
                BundleId = "com.mobilife.gsb.mymo",
                IdOnAppStore = "987047466"
            });
            List.Add(new BankingListModel
            {
                Name = "bualuangmbanking",
                BundleId = "com.bbl.mobilebanking",
                IdOnAppStore = "660238716"
            });
            List.Add(new BankingListModel
            {
                Name = "krungsri-kma",
                BundleId = "com.krungsri.kma",
                IdOnAppStore = "571873195"
            });
            List.Add(new BankingListModel
            {
                Name = "tmbtouch",
                BundleId = "com.TMBTOUCH.PRODUCTION",
                IdOnAppStore = "884079963"
            });
            List.Add(new BankingListModel
            {
                Name = "ThanachartConnect",
                BundleId = "th.co.thanachartbank.mbanking",
                IdOnAppStore = "1097485544"
            });
            List.Add(new BankingListModel
            {
                Name = "mightythapp",
                BundleId = "com.uob.mightyth2",
                IdOnAppStore = "1220331876"
            });
            List.Add(new BankingListModel
            {
                Name = "GHB ALL",
                BundleId = "com.gov.ghb.ghball",
                IdOnAppStore = "1437354756"
            });
            List.Add(new BankingListModel
            {
                Name = "paotang",
                BundleId = "com.ktb.customer.qr",
                IdOnAppStore = "1324902182"
            });
            return List;
        }
    }

    public class BankingListModel
    {
        public string Name { get; set; }
        public string BundleId { get; set; }
        public string IdOnAppStore { get; set; }
    }
}
