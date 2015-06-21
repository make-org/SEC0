using System;
using System.IO;
using System.Diagnostics;

namespace sys_shrtcut
{
  public partial class main(string[] args)
  {
    public string _(string v)
    {
      return v;
    }
    // the system shortcut is a shortucut for open the console
    Process.Start("app.cs"); // CHANGE TO .exe IF compiled
    Console.write(_("PROCESS STARTED WITH SUCESS"));
  }
}
