using Data.Regimes;
using Data.Regimes.ConcreteRegimes;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Data.BinaryFiles
{

    public class RegFileFactory
    {
        private readonly Queue<byte> bytes;

        public RegFileFactory(Queue<byte> bytes)
        {
            this.bytes = bytes;
        }

        Reg10 mes = new Reg10();
        Queue<byte> buf = new Queue<byte>();
        List<RegBase> rb = new List<RegBase>();
       
        public  IEnumerable<RegBase> Create(IEnumerable<byte> bytes)
        {         
            foreach (var b in bytes)
            {                
                buf.Enqueue(b);
                if (buf.Count < mes.RegSize)
                    continue;

                var result = new Reg10(buf);
                if (result.IsValid)
                {
                    rb.Add(result);
                    mes = new Reg10();
                    buf.Clear();
                    continue;
                }
                
                buf.Dequeue();



                if (buf.Count < mes.RegSize)
                {
                    byte b;
                    bytes.TryDequeue(out b);
                    buf.Enqueue(b);
                }
                else 
                {
                    var result = mes.Parse(buf.ToArray());

                    if (result)
                    {
                        rb.Add(mes);
                        buf.Clear();
                        mes = new Reg10();
                    }
                    else
                    {
                        buf.Dequeue();
                    }
                }


            }
            return rb;
        }
    }
}
