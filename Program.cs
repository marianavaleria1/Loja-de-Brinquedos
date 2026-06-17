using System;

public class Produto
{
    public int Codigo;
    public string Descricao;
    public decimal PrecoCompra;
    public decimal PrecoVenda;
    public int Estoque;
}

class Program
{
    const int MAX_PRODUTOS = 500;

    static Produto[] produtos = new Produto[MAX_PRODUTOS];
    static int quantidadeProdutos = 0;
    static int proximoCodigo = 1;

    static void Main()
    {
        int opcao;

        /* 
        * Escreva o menu utilizando a estrututura de repetição do-while 
        *   - O usuário deverá entrar com uma opção entre:
        *       -- Cadastrar Produto
        *       -- Frente de Caixa
        *       -- Consultar Estoque
        *       -- Entrada de Produtos
        *       -- Listagem de Produtos
        *       -- Sair
        *
        * Utilize a estrutura switch-case para validar a entrada do usuário
        */
        
    }

    /**
    * Procura um produto no vetor de produtos utilizando seu código.
    *
    * @param codigoBuscado Código do produto que será pesquisado.
    * @return A posição do produto no vetor caso ele seja encontrado.
    *         Retorna -1 caso não exista nenhum produto cadastrado
    *         com o código informado.
    */
    static int BuscarProduto(int codigoBuscado)
    {
        
    }

    /*
    * Responsável por realizar o cadastro de um novo produto no sistema.
    *
    * A função deve:
    * - Verificar se ainda existe espaço disponível para novos produtos;
    * - Criar um novo produto;
    * - Gerar automaticamente um código único para o produto;
    * - Solicitar ao usuário as informações necessárias para o cadastro;
    * - Armazenar o produto na estrutura de dados utilizada pelo sistema;
    * - Atualizar a quantidade de produtos cadastrados.
    *
    * Caso o limite máximo de produtos seja atingido, o cadastro não deve ser realizado.
    */
    static void CadastrarProduto()
    {
        
    }

    /*
    * Responsável por registrar a venda de produtos.
    *
    * A função deve:
    * - Permitir que o usuário informe os códigos dos produtos comprados;
    * - Encerrar o processo de venda quando o usuário informar o código 0;
    * - Verificar se o código informado existe no sistema (BuscarProduto);
    * - Verificar se há quantidade disponível em estoque;
    * - Exibir os dados dos produtos vendidos;
    * - Atualizar o estoque após cada venda realizada;
    * - Calcular o valor total da compra;
    * - Exibir o total da compra ao final do atendimento.
    *
    * Caso um código informado não exista, uma mensagem de erro deve ser exibida.
    * Caso o produto não possua estoque disponível, a venda não deve ser realizada.
    */
    static void FrenteDeCaixa()
    {
        
    }

    /*
    * Responsável por consultar as informações de um produto
    * cadastrado no sistema.
    *
    * A função deve:
    * - Solicitar ao usuário o código do produto desejado;
    * - Verificar se o código informado existe (BuscarProduto);
    * - Localizar o produto correspondente;
    * - Exibir todas as informações do produto encontrado:
    *   - Código;
    *   - Descrição;
    *   - Preço de compra;
    *   - Preço de venda;
    *   - Quantidade em estoque.
    *
    * Caso o código informado não exista, uma mensagem de erro
    * deve ser exibida ao usuário.
    */
    static void ConsultarEstoque()
    {
        
    }

    /*
    * Responsável por registrar a entrada de novos produtos
    * no estoque da loja.
    *
    * A função deve:
    * - Solicitar ao usuário o código do produto que será atualizado;
    * - Verificar se o código informado existe (BuscarProduto);
    * - Solicitar a quantidade de itens recebidos;
    * - Solicitar o novo preço de compra do produto;
    * - Solicitar o novo preço de venda do produto;
    * - Atualizar a quantidade disponível em estoque;
    * - Atualizar os preços de compra e venda do produto.
    *
    * Caso o código informado não exista, uma mensagem de erro
    * deve ser exibida ao usuário.
    */
    static void EntradaProdutos()
    {
        
    }

    /*
    * Responsável por exibir todos os produtos cadastrados no sistema.
    *
    * A função deve:
    * - Verificar se existe ao menos um produto cadastrado;
    * - Percorrer a estrutura que armazena os produtos;
    * - Exibir as informações de cada produto:
    *   - Código;
    *   - Descrição;
    *   - Preço de compra;
    *   - Preço de venda;
    *   - Quantidade em estoque.
    *
    * Caso não existam produtos cadastrados, uma mensagem
    * informando essa situação deve ser exibida ao usuário.
    */
    static void ListarProdutos()
    {
       
    }
}