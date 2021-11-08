using System;

namespace BusinessLayer
{
    public class LoanCalculator
    {
        public double LoanCalculation(double monto, int tipoPrestamo, int cuotaMensual)
        {

            double loanQuantity = 0;
            switch (tipoPrestamo)
            {
                case (int)LoanEnum.PERSONAL:
                    loanQuantity = ((monto * 0.22) + monto)/cuotaMensual;
                    break;
                case (int)LoanEnum.AUTOMOVIL:
                    loanQuantity = ((monto * 0.12) + monto) / cuotaMensual;
                    break;
                case (int)LoanEnum.HIPOTECARIO:
                    loanQuantity = ((monto * 0.08) + monto) / cuotaMensual;
                    break;
            }
            return loanQuantity;
        }
    }
}
