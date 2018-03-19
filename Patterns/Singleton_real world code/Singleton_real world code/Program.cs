using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Singleton.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Singleton Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    class LoadBalancer
    {
        private static LoadBalancer _instance;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        // Lock synchronization object
        private static object syncLock = new object();

        // Constructor (protected)
        protected LoadBalancer()
        {
            // List of available servers
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Support multithreaded applications through - Поддержка многопоточных приложений через
            // 'Double checked locking' pattern which (once - «Двойная проверка блокировки», которая (один раз
            // the instance exists) avoids locking each - экземпляр существует) позволяет избежать блокировки каждого
            // time the method is invoked - время вызова метода
            if (_instance == null)
            {
                //Ключевое слово lock не позволит одному потоку войти в важный раздел кода в тот момент, когда в нем находится другой поток. 
                //При попытке входа другого потока в заблокированный код потребуется дождаться снятия блокировки объекта.
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }

        // Simple, but effective random load balancer
        public string Server
        {
            get
            {
                //случайное число от 0 до count
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}