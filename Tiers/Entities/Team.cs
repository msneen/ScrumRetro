using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tiers.Entities
{
    public class Team
    {
        #region Member Variables
        private List<Member> _members;
        #endregion

        #region Properties
        public List<Member> Members 
        {
            get 
            {
                if (_members == null)
                {
                    _members = new List<Member>();
                }

                return _members;
            }

            set { _members = value; }
        }
        #endregion
    }
}
