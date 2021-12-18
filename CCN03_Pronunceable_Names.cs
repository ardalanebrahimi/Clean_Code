using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Code_Naming
{
    class CCN03_Pronunceable_Names
    {
        /// <summary>
        /// sample 1
        /// Property to store timestamp of data generation time
        /// </summary>
        public string GenYMDHMs { get; set; }
        public string GenerationTimestamp { get; set; }

        /// <summary>
        /// sample 2
        /// Real world Example
        /// stands for Product Provision transaction detail, Time dependent Detail!
        /// stands for Product Provision transaction detail, Time independent Detail!
        /// </summary>
        class PrdProvTranDtlTDD 
        { 
        }
        class PrdProvTranDtlTID 
        {            
        }
        //Alternative
        class SampleType :
            IProductProvision,
            IProductDetail,
            ITransactionalEntity,
            ITimeDependantEntity
        {

        }
    }

    internal interface ITimeDependantEntity
    {
    }

    internal interface ITransactionalEntity
    {
    }

    internal interface IProductDetail
    {
    }

    internal interface IProductProvision
    {
    }
}
