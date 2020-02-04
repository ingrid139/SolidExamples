using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidExamples.S
{
    public class SingleResponsiblityPrinciple
    {
        //a classe deve ter uma única tarefa ou ação para executar.

        public class PedidoService
        {
            //informar
            public void calculateTotalSum() {/*...*/}
            public void getItems() {/*...*/}
            public void getItemCount() {/*...*/}
            public void addItem(Item item) {/*...*/}
            public void deleteItem(Item item) {/*...*/}
        }
        public class PedidoViewer
        {
            //exibir
            public void printOrder(Pedido pedidoCliente) {/*...*/}
            public void showOrder(Pedido pedidoCliente) {/*...*/}
        }

        public class PedidoRepository
        {
            //manipular
            public void load(Pedido pedidoCliente) {/*...*/}
            public void save(Pedido pedidoCliente) {/*...*/}
            public void update(Pedido pedidoCliente) {/*...*/}
            public void delete(Pedido pedidoCliente) {/*...*/}
        }

        public class Item
        {
            public int Quantidade { get; set; }
            public string Tipo { get; set; }
        }

        public class Pedido
        {
            public int PedidoId { get; set; }
            public Item item { get; set; }
        }


        public class SRPMethod
        {
            //Ruim:
            public void emailClientes(List<Cliente> clientes)
            {
                foreach (var cliente in clientes) {
                    //1
                    var clienteOn = getClienteById(cliente.Id);

                    //2
                    if (clienteOn.isActive()) {
                        //3
                        sendEmail(cliente);
                    }
                }
            }

           
            // Bom:
            public void sendEmailClients(List<Cliente> clientes)
            {
                var clientesAtivos = activeClients(clientes);
                clientesAtivos.ForEach(x => sendEmail(x));
            }

            public List<Cliente> activeClients(List<Cliente> clientes)
            {
                return clientes.Where(x => isClientActive(x)).ToList();
            }

            public bool isClientActive(Cliente cliente)
            {
                var clienteAtivo = getClienteById(cliente.Id);

                return clienteAtivo.isActive();
            }

            private Cliente getClienteById(Guid clienteId)
            {
                return new Cliente();
            }
            private void sendEmail(Cliente cliente)
            {
                //send email
            }

            public class Cliente
            {
                public Guid Id { get; set; }
                public string Nome { get; set; }
                public bool Status { get; set; }

                public bool isActive()
                {
                    return Status;
                }
            }
        }
    }
}
