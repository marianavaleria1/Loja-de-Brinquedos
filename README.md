# Sistema de Controle para Loja de Brinquedos

## Introdução

Uma loja de brinquedos realiza diariamente operações de compra, venda e controle de estoque de seus produtos. Atualmente, essas informações são registradas manualmente, o que dificulta o controle das mercadorias disponíveis e aumenta a possibilidade de erros durante o atendimento aos clientes.

Para solucionar esse problema, será desenvolvido um sistema de gerenciamento capaz de cadastrar produtos, controlar o estoque, registrar vendas e consultar informações dos itens comercializados pela loja.

O objetivo deste projeto é aplicar os conceitos estudados na disciplina de Linguagem de Programação, transformando uma especificação descrita em linguagem natural em um programa funcional.

---

# Objetivos de Aprendizagem

Ao desenvolver este projeto, o aluno deverá praticar os seguintes conceitos:

* Declaração e utilização de variáveis;
* Estruturas condicionais (`if`, `else`, `switch`);
* Estruturas de repetição (`for`, `while`, `do-while`);
* Vetores (arrays);
* Modularização através de funções;
* Entrada e saída de dados pelo console;
* Manipulação de dados em memória;
* Desenvolvimento de algoritmos para resolução de problemas.

---

# Descrição do Problema

O sistema deverá permitir o controle dos produtos comercializados por uma loja de brinquedos.

Cada produto deverá possuir as seguintes informações:

| Campo           | Descrição                                               |
| --------------- | ------------------------------------------------------- |
| Código          | Identificador único gerado automaticamente pelo sistema |
| Descrição       | Nome ou descrição do produto                            |
| Preço de Compra | Valor pago pela loja ao adquirir o produto              |
| Preço de Venda  | Valor cobrado do cliente                                |
| Estoque         | Quantidade disponível para venda                        |

O sistema deverá permitir o cadastro de até 500 produtos.

---

# Funcionalidades Obrigatórias

## 1. Cadastro de Produtos

Permitir ao usuário cadastrar um novo produto informando:

* Descrição;
* Preço de compra;
* Preço de venda;
* Quantidade em estoque.

O código do produto deverá ser gerado automaticamente pelo sistema.

---

## 2. Frente de Caixa

Permitir registrar a venda de produtos.

O usuário deverá informar os códigos dos produtos vendidos.

Ao final da venda, o sistema deverá exibir:

* Código do produto;
* Descrição;
* Preço de venda;
* Valor total da compra.

Além disso, a quantidade vendida deverá ser descontada do estoque.

---

## 3. Consulta de Estoque

Permitir consultar um produto através de seu código.

O sistema deverá exibir:

* Código;
* Descrição;
* Preço de compra;
* Preço de venda;
* Quantidade em estoque.

---

## 4. Entrada de Produtos

Permitir registrar a chegada de novas mercadorias.

O usuário deverá informar:

* Código do produto;
* Quantidade adquirida;
* Novo preço de compra;
* Novo preço de venda.

O sistema deverá atualizar os dados do produto.

---

## 5. Listagem de Produtos

Exibir todos os produtos cadastrados contendo:

* Código;
* Descrição;
* Preço de compra;
* Preço de venda;
* Quantidade em estoque.

---

## 6. Encerramento do Programa

Permitir ao usuário finalizar a execução do sistema.

---

# Classe

Neste trabalho utilizamos o conceito de classe, onde basicamente, criamos uma estrutura para representar um objeto do mundo real (este objeto pode ser real ou abstrato).
A estrutura deste objeto é definida através de uma classe, neste trabalho, a classe Produto.

A classe Produto contém atributos, são estes:
- <b>Codigo</b> -> Definie o código produto
- <b>Descricao</b> -> Define a descrição daquele produto
- <b>PrecoCompra</b> -> Define o preço de compra daquele produto
- <b>PrecoVenda</b> -> Define o preço de venda daquele produto
- <b>Estoque</b> -> Define a quantidade em estoque daquele produto

### Como utilizar uma objeto de uma classe?

Para utilizarmos uma classe, primeiro precisamos instanciar (criar) um objeto a partir dela. Este objeto será uma variável do tipo Produto.

```csharp
Produto produto = new Produto();
```

A partir do objeto instanciado, podemos manipular seus atributos acessando da seguinte forma:
```csharp
produto.Codigo;
```

### Exemplos
1. Atribuir uma descrição ao produto
```csharp
produto.Descricao = "Bola de futebol";
```

2. Incrementar a quantidade em estoque
```csharp
produto.Estoque++;
```

3. Exibindo o preço de venda de um produto
```csharp
Console.WriteLine($"Valor de venda: {produto.PrecoVenda}");
```
---

# Regras de Negócio

## Código inexistente

Sempre que o usuário informar um código que não esteja cadastrado, o sistema deverá exibir a mensagem:

```text
Código inexistente.
```

## Controle de Estoque

O sistema não deverá permitir a venda de produtos sem estoque disponível.

Exemplo:

```text
Produto sem estoque.
```

## Limite de Produtos

O sistema deverá permitir o cadastro de no máximo 500 produtos.

---

# Estrutura Recomendada

Para facilitar a organização do código, recomenda-se criar funções para cada funcionalidade.

Exemplo:

```csharp
Main()
│
├── CadastrarProduto()
├── FrenteDeCaixa()
├── ConsultarEstoque()
├── EntradaProdutos()
├── ListarProdutos()
└── BuscarProduto()
```

A função `BuscarProduto()` pode ser utilizada para localizar a posição de um produto nos vetores a partir de seu código, evitando repetição de código.

---

# Exemplo de Menu

```text
=================================
      LOJA DE BRINQUEDOS
=================================
1 - Cadastrar Produto
2 - Frente de Caixa
3 - Consultar Estoque
4 - Entrada de Produtos
5 - Listagem de Produtos
6 - Sair
=================================
Escolha uma opção:
```

---

# Critérios de Avaliação

Os seguintes aspectos serão considerados durante a correção:

* Funcionamento correto das funcionalidades;
* Organização do código;
* Modularização utilizando funções;
* Legibilidade e identação;
* Tratamento adequado das regras de negócio;
* Atendimento completo aos requisitos propostos.

---

# Dicas de Desenvolvimento

1. Desenvolva uma funcionalidade por vez.
2. Teste cada função antes de continuar.
3. Utilize nomes de variáveis claros e significativos.
4. Evite repetir trechos de código.
5. Mantenha a identação organizada.
6. Comente partes importantes do programa.
7. Realize testes com diferentes cenários antes da entrega.

---

# Resultado Esperado

Ao final do projeto, o aluno deverá ter desenvolvido um sistema capaz de gerenciar os produtos de uma loja de brinquedos, permitindo cadastrar produtos, controlar estoque, registrar vendas e consultar informações de forma organizada e eficiente.
