# O padrão _Prototype_

Bem vindos ao último artigo sobre padrões de projeto criacionais, se você caro leitor, não leu os artigos anteriores pode encontrá-los disponíveis no meu [GitHub](https://github.com/Dsouzavl?tab=repositories). Hoje falaremos sobre o padrão _Prototype_, a idéia por trás dele é fornecer em casos necessários, uma cópia de um objeto, ao invés de um novo objeto, uma nova instância, lembrando rapidamente do nosso artigo falando sobre _Singleton_, citei o exemplo de capturamos um response que se altera de 1 em 1 mês, ou 1 em 1 semana, e criar um _Singleton_ que será devolvido toda vez que for solicitado, ao invés de a cada solicitação, for feito um novo request, se tivéssemos um alto número de clientes desse response, cheiraria a ataque Ddos, esse caso também pode ser resolvido com o padrão prototype, poderíamos guardar um objeto, que no caso seria o nosso response, e toda vez que ele fosse solicitado, devolveríamos uma cópia desse objeto ao invés de criarmos um novo, isso remete ao primeiro caso de uso do _prototype_, que diz que devemos utilizá-lo toda vez que a construção de um objeto for custosa, e não houver uma real neessidade dela, podendo ser fornecida uma cópia do objeto já existente. Os outros dois casos de uso remetem á quando você quer salvar um estado de um objeto constantemente mutável, você utiliza o _prototype_ para criar uma cópia desse objeto com esse estado desejado, que poderá ser manipulado e acessado. Há o caso em que você tem uma série de construtores extremamente complexos, com diferentes tipos e número de parâmetros, a idéia é que ao invés de submeter o usuário a criar um objeto complexo, ele receba uma cópia desse objeto existente através do _prototype_ para que possa manipular o objeto, sem ter que enfrentar a complexidade de construção, quando ele já é existente e basta um cópia. 

```csharp
 public class MutableResponse : ICloneable {

        string response { get; set; }

        public void DisplayResponse() 
        {
            Console.WriteLine(response);
            Console.ReadLine();
        }

        public object Clone() {
            return MemberwiseClone();
        }
    }
``` 
A forma mais simples de criar um _prototype_ que nada mais é que um objeto que tem a capacidade de ser clonado, é implementando a interface **ICloneable** na sua classe, e implementando o método **Clone()**, no nosso caso estamos retornando uma cópia rasa da nossa classe: _Cópias rasas são cópias que copiam apenas a referência do objeto, você tem um objeto novo, mas com a a refrência para o espaço em memória do objeto base, enquanto que uma Deep copy, faz a copia do objeto em si, e não apenas a referência_. Há como criar um protótipo utilizando classes abstratas e sua maneira única de implementar o método **Clone()**, para casos mais complexos pode vir a ser bem útil, mas como estamos lidando com os exemplos, essa interface nos garante o funcionamento, eu uma boa demonstração de como implementar o padrão _prototype_ de uma maneira fácil. 

```csharp
class Program {
        static void Main(string[] args) {
            var response = new MutableResponse();
            response.response = "pagina html";
            response.DisplayResponse();

            var response2 = response.Clone() as MutableResponse;
            response2.DisplayResponse();
            
        }
    }
```
Criamos uma cópia de forma rápida e elegante, o método **Clone()** tem como retorno um **object** ( _regras da interface kk_) por isso fazemos cast do object retornado para nossa classe protótipa, assim podemos utilizar seus métodos e propriedades.


## Final

Espero que esse artigo tenha ajudado a compreender um pouco mais sobre o padrão prototype, eu não sei quais os próximos temas que estarei escrevendo, acabamos com os padrões criacionais, estude, ame e sempre lembre deles na hora de construir seus sistemas OO.

Obrigado leitores!
