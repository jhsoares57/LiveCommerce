using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCommerce.Model
{
     public class ContasPagarReceber
     {
        private int codCont;
        private int ctpCont;
        private DateTime cdtLanc;
        private int ccodOri;
        private double cvlrCnt;
        private DateTime ddtPag;
        private DateTime cdtVcto;
        private string cobs;

        public int CodCont { get => codCont; set => codCont = value; }
        public int CtpCont { get => ctpCont; set => ctpCont = value; }
        public DateTime CdtLanc { get => cdtLanc; set => cdtLanc = value; }
        public int CcodOri { get => ccodOri; set => ccodOri = value; }
        public double CvlrCnt { get => cvlrCnt; set => cvlrCnt = value; }
        public DateTime DdtPag { get => ddtPag; set => ddtPag = value; }
        public DateTime CdtVcto { get => cdtVcto; set => cdtVcto = value; }
        public string Cobs { get => cobs; set => cobs = value; }
    }
}
