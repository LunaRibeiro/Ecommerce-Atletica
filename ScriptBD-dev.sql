create database bdecommerceatletica_dev

use  bdecommerceatletica_dev

-- Criando a tabela tb_pessoa
CREATE TABLE tb_pessoa(
	id int auto_increment primary key,
    nome varchar(100) not null,
    usuario varchar(50),
    senha varchar (255) not null,
    email varchar (254) not null
);

-- Criando a tabela tb_cliente
create table tb_cliente(
	id int auto_increment primary key,
    id_pessoa int not null,
    documento varchar (20) not null,
    endereco varchar(255) not null,
    idade int not null,
    telefone varchar (15) not null,
    associado ENUM('Sim', 'Não'),
    adm ENUM ('Sim', 'Não'),
    foreign key (id_pessoa) references tb_pessoa(id)
);

-- Criando a tabela tb_categoria
create table tb_categoria(
	id int auto_increment primary key,
    tipo_produto ENUM('Roupas', 'Acessórios', 'Associação', 'Eventos') not null
);

-- Criando a tabela tb_produto
create table tb_produto(
	id int auto_increment primary key,
    nome_produto varchar (100) not null,
    descricao varchar (254),
    preco_unitario decimal (10,2) not null,
    quantidade int not null,
    id_categoria int not null,
    foreign key (id_categoria) references tb_categoria(id)
);

-- Criando a tabela tb_carrinho
create table tb_carrinho(
	id int auto_increment primary key,
    id_cliente int not null,
    valor_total_carrinho decimal (10,2) not null,
    foreign key (id_cliente) references tb_cliente(id)
);

-- Criando a tabela tb_carrinho_produto
create table tb_carrinho_produto(
	id int auto_increment primary key,
    id_carrinho int not null,
    id_produto int not null,
    quantidade int,
    valor_total_produto decimal (10,2),
    foreign key (id_carrinho) references tb_carrinho(id),
    foreign key (id_produto) references tb_produto(id)
);

-- Criando a tabela tb_pedido
create table tb_pedido(
	id int auto_increment primary key,
    id_cliente int not null,
    id_carrinho int not null,
    data_pedido date not null,
    valor_total decimal (10,2) not null,
    status_pedido enum ('Pendente', 'Cancelado', 'Concluido') not null,
    foreign key (id_cliente) references tb_cliente(id),
    foreign key (id_carrinho) references tb_carrinho(id)
);

-- Criando a tabela tb_forma_pagamento
create table tb_forma_pagamento(
	id int auto_increment primary key,
    id_pedido int not null,
    data_pagamento date not null,
    metodo_pagamento enum ('Pix', 'Cartão de Débito', 'Cartão de Crédito'),
    valor_total decimal (10,2) not null,
    foreign key (id_pedido) references tb_pedido(id)
);

-- Criando a tabela tb_cupom_desconto
create table tb_cupom_desconto(
	id int auto_increment primary key,
    id_cliente int not null,
    tipo_cliente enum ('Sócio', 'Não Sócio'),
    valor_desconto decimal (10,2) not null,
    foreign key (id_cliente) references tb_cliente(id)
    );

























