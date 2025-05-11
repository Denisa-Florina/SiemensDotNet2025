using ProblemSiemensDonNet.repository;
using ProblemSiemensDonNet.service;

namespace ProblemSiemensDonNet;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Service service = new Service(new BookRepository());
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1(service));
    }
}