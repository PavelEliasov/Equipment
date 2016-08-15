using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment {
   public class AutorityManager {

        private static AutorityManager manager;
        bool isAdmin;

        public bool IsAdmin{
            get {
                return isAdmin;
            }

            set {
                isAdmin = value;
            }
        }

        public static AutorityManager GetInstance() {
            if (manager==null) {
               manager = new AutorityManager();
            }
            return manager;
        }

    }
}
