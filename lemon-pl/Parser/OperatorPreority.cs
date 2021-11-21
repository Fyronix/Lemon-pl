using System;
using System.Collections.Generic;
using System.Text;

namespace lemon_pl.lemon-pl.Parser
{
    class OperatorPreority
    {
        public static string[][] Preority =
        {

                    new string[]{  ","                                  },
                    new string[]{  "++", "--",                          },
                    new string[]{  ":",                                 },
                    new string[]{  "and", "or" ,                        },
                    new string[]{  "=", "!=" , ">", "<", ">=", "<=",    },
                    new string[]{  "+", "-",                            },
                    new string[]{  "*", "/",                            },
                    new string[]{  "[]", "."                            }

        };
    }
}
