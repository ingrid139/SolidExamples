
namespace SolidExamples.S
{
    public class ViolationSingleResponsiblityPrinciple
    {
        //sabe demais ou faz demais
        public class GodClass
        {
            public class Pedido
            {
                //informar
                public void calculateTotalSum() {/*...*/}
                public void getItems() {/*...*/}
                public void getItemCount() {/*...*/}
                public void addItem(Item item) {/*...*/}
                public void deleteItem(Item item) {/*...*/}

                //exibir
                public void printPedido() {/*...*/}
                public void showPedido() {/*...*/}

                //manipular
                public void load() {/*...*/}
                public void save() {/*...*/}
                public void update() {/*...*/}
                public void delete() {/*...*/}
            }

            public class Item
            {
                public int Quantidade { get; set; }
                public string Tipo { get; set; }
            }
        }

    
    }
}
