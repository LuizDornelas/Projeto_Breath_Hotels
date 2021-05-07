PGDMP     2                    y            BreathHotels    13.2    13.2 >               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    32797    BreathHotels    DATABASE     n   CREATE DATABASE "BreathHotels" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Portuguese_Brazil.1252';
    DROP DATABASE "BreathHotels";
                postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
                postgres    false                       0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                   postgres    false    3            �            1259    41132    cartao    TABLE       CREATE TABLE public.cartao (
    cartaoid integer NOT NULL,
    numerocartao character varying(50),
    nome character varying(50),
    validade character varying(30),
    codigo character varying(30),
    bandeira character varying(30),
    usuariofk integer
);
    DROP TABLE public.cartao;
       public         heap    postgres    false    3            �            1259    41130    cartao_cartaoid_seq    SEQUENCE     �   CREATE SEQUENCE public.cartao_cartaoid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public.cartao_cartaoid_seq;
       public          postgres    false    212    3                       0    0    cartao_cartaoid_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public.cartao_cartaoid_seq OWNED BY public.cartao.cartaoid;
          public          postgres    false    211            �            1259    49332    consumos    TABLE     �   CREATE TABLE public.consumos (
    consumoid integer NOT NULL,
    item character varying(50),
    valor numeric,
    quantidade integer,
    data timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    reservafk integer,
    itemfk integer
);
    DROP TABLE public.consumos;
       public         heap    postgres    false    3            �            1259    49330    consumos_consumoid_seq    SEQUENCE     �   CREATE SEQUENCE public.consumos_consumoid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.consumos_consumoid_seq;
       public          postgres    false    3    214            	           0    0    consumos_consumoid_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.consumos_consumoid_seq OWNED BY public.consumos.consumoid;
          public          postgres    false    213            �            1259    41124 
   fornecedor    TABLE     y   CREATE TABLE public.fornecedor (
    fornecedorid integer NOT NULL,
    item character varying(30),
    valor numeric
);
    DROP TABLE public.fornecedor;
       public         heap    postgres    false    3            �            1259    41122    fornecedor_fornecedorid_seq    SEQUENCE     �   CREATE SEQUENCE public.fornecedor_fornecedorid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public.fornecedor_fornecedorid_seq;
       public          postgres    false    3    210            
           0    0    fornecedor_fornecedorid_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public.fornecedor_fornecedorid_seq OWNED BY public.fornecedor.fornecedorid;
          public          postgres    false    209            �            1259    41116    itens    TABLE     �   CREATE TABLE public.itens (
    itemid integer NOT NULL,
    item character varying(30),
    valor numeric,
    quantidade integer,
    status character varying(30)
);
    DROP TABLE public.itens;
       public         heap    postgres    false    3            �            1259    41114    itens_itemid_seq    SEQUENCE     �   CREATE SEQUENCE public.itens_itemid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.itens_itemid_seq;
       public          postgres    false    3    208                       0    0    itens_itemid_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.itens_itemid_seq OWNED BY public.itens.itemid;
          public          postgres    false    207            �            1259    32862    login    TABLE     �   CREATE TABLE public.login (
    loginid integer NOT NULL,
    login character varying(50),
    senha character varying(50),
    ativo character varying(30) DEFAULT 'Desativado'::character varying,
    tipo character varying(30),
    fk_usuario integer
);
    DROP TABLE public.login;
       public         heap    postgres    false    3            �            1259    32860    login_id_seq    SEQUENCE     �   CREATE SEQUENCE public.login_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.login_id_seq;
       public          postgres    false    201    3                       0    0    login_id_seq    SEQUENCE OWNED BY     B   ALTER SEQUENCE public.login_id_seq OWNED BY public.login.loginid;
          public          postgres    false    200            �            1259    41101    quartos    TABLE     �   CREATE TABLE public.quartos (
    quarto character varying(30) NOT NULL,
    tipo character varying(30),
    camasolteiro integer DEFAULT 0,
    camacasal integer DEFAULT 0,
    status character varying(30),
    reservafk integer,
    diaria numeric
);
    DROP TABLE public.quartos;
       public         heap    postgres    false    3            �            1259    41078    reservas    TABLE     b  CREATE TABLE public.reservas (
    reservaid integer NOT NULL,
    nomefunc character varying(50),
    nomecli character varying(50),
    entrada timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    saida timestamp without time zone,
    valor numeric,
    quartofk character varying(30),
    status character varying(30),
    usuariofk integer
);
    DROP TABLE public.reservas;
       public         heap    postgres    false    3            �            1259    41076    reservas_reservaid_seq    SEQUENCE     �   CREATE SEQUENCE public.reservas_reservaid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.reservas_reservaid_seq;
       public          postgres    false    3    205                       0    0    reservas_reservaid_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.reservas_reservaid_seq OWNED BY public.reservas.reservaid;
          public          postgres    false    204            �            1259    32886    usuario    TABLE     �  CREATE TABLE public.usuario (
    usuarioid integer NOT NULL,
    nome character varying(50),
    rg character varying(30),
    telefone character varying(20),
    rua character varying(50),
    numero character varying(10),
    bairro character varying(50),
    cidade character varying(50),
    estado character varying(50),
    cep character varying(10),
    ativo character varying(30) DEFAULT 'SIM'::character varying
);
    DROP TABLE public.usuario;
       public         heap    postgres    false    3            �            1259    32884    usuario_id_seq    SEQUENCE     �   CREATE SEQUENCE public.usuario_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.usuario_id_seq;
       public          postgres    false    3    203                       0    0    usuario_id_seq    SEQUENCE OWNED BY     H   ALTER SEQUENCE public.usuario_id_seq OWNED BY public.usuario.usuarioid;
          public          postgres    false    202            W           2604    41135    cartao cartaoid    DEFAULT     r   ALTER TABLE ONLY public.cartao ALTER COLUMN cartaoid SET DEFAULT nextval('public.cartao_cartaoid_seq'::regclass);
 >   ALTER TABLE public.cartao ALTER COLUMN cartaoid DROP DEFAULT;
       public          postgres    false    211    212    212            X           2604    49335    consumos consumoid    DEFAULT     x   ALTER TABLE ONLY public.consumos ALTER COLUMN consumoid SET DEFAULT nextval('public.consumos_consumoid_seq'::regclass);
 A   ALTER TABLE public.consumos ALTER COLUMN consumoid DROP DEFAULT;
       public          postgres    false    214    213    214            V           2604    41127    fornecedor fornecedorid    DEFAULT     �   ALTER TABLE ONLY public.fornecedor ALTER COLUMN fornecedorid SET DEFAULT nextval('public.fornecedor_fornecedorid_seq'::regclass);
 F   ALTER TABLE public.fornecedor ALTER COLUMN fornecedorid DROP DEFAULT;
       public          postgres    false    209    210    210            U           2604    41119    itens itemid    DEFAULT     l   ALTER TABLE ONLY public.itens ALTER COLUMN itemid SET DEFAULT nextval('public.itens_itemid_seq'::regclass);
 ;   ALTER TABLE public.itens ALTER COLUMN itemid DROP DEFAULT;
       public          postgres    false    207    208    208            Q           2604    41081    reservas reservaid    DEFAULT     x   ALTER TABLE ONLY public.reservas ALTER COLUMN reservaid SET DEFAULT nextval('public.reservas_reservaid_seq'::regclass);
 A   ALTER TABLE public.reservas ALTER COLUMN reservaid DROP DEFAULT;
       public          postgres    false    204    205    205            �          0    41132    cartao 
   TABLE DATA           e   COPY public.cartao (cartaoid, numerocartao, nome, validade, codigo, bandeira, usuariofk) FROM stdin;
    public          postgres    false    212   �F                  0    49332    consumos 
   TABLE DATA           _   COPY public.consumos (consumoid, item, valor, quantidade, data, reservafk, itemfk) FROM stdin;
    public          postgres    false    214   �G       �          0    41124 
   fornecedor 
   TABLE DATA           ?   COPY public.fornecedor (fornecedorid, item, valor) FROM stdin;
    public          postgres    false    210   H       �          0    41116    itens 
   TABLE DATA           H   COPY public.itens (itemid, item, valor, quantidade, status) FROM stdin;
    public          postgres    false    208   kH       �          0    32862    login 
   TABLE DATA           O   COPY public.login (loginid, login, senha, ativo, tipo, fk_usuario) FROM stdin;
    public          postgres    false    201   �H       �          0    41101    quartos 
   TABLE DATA           c   COPY public.quartos (quarto, tipo, camasolteiro, camacasal, status, reservafk, diaria) FROM stdin;
    public          postgres    false    206   (I       �          0    41078    reservas 
   TABLE DATA           t   COPY public.reservas (reservaid, nomefunc, nomecli, entrada, saida, valor, quartofk, status, usuariofk) FROM stdin;
    public          postgres    false    205   �I       �          0    32886    usuario 
   TABLE DATA           q   COPY public.usuario (usuarioid, nome, rg, telefone, rua, numero, bairro, cidade, estado, cep, ativo) FROM stdin;
    public          postgres    false    203   �J                  0    0    cartao_cartaoid_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.cartao_cartaoid_seq', 3, true);
          public          postgres    false    211                       0    0    consumos_consumoid_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.consumos_consumoid_seq', 3, true);
          public          postgres    false    213                       0    0    fornecedor_fornecedorid_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.fornecedor_fornecedorid_seq', 3, true);
          public          postgres    false    209                       0    0    itens_itemid_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.itens_itemid_seq', 3, true);
          public          postgres    false    207                       0    0    login_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.login_id_seq', 6, true);
          public          postgres    false    200                       0    0    reservas_reservaid_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.reservas_reservaid_seq', 3, true);
          public          postgres    false    204                       0    0    usuario_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.usuario_id_seq', 7, true);
          public          postgres    false    202            g           2606    41137    cartao cartaoidpk 
   CONSTRAINT     U   ALTER TABLE ONLY public.cartao
    ADD CONSTRAINT cartaoidpk PRIMARY KEY (cartaoid);
 ;   ALTER TABLE ONLY public.cartao DROP CONSTRAINT cartaoidpk;
       public            postgres    false    212            i           2606    49341    consumos consumoidpk 
   CONSTRAINT     Y   ALTER TABLE ONLY public.consumos
    ADD CONSTRAINT consumoidpk PRIMARY KEY (consumoid);
 >   ALTER TABLE ONLY public.consumos DROP CONSTRAINT consumoidpk;
       public            postgres    false    214            e           2606    41129    fornecedor fornecedoridpk 
   CONSTRAINT     a   ALTER TABLE ONLY public.fornecedor
    ADD CONSTRAINT fornecedoridpk PRIMARY KEY (fornecedorid);
 C   ALTER TABLE ONLY public.fornecedor DROP CONSTRAINT fornecedoridpk;
       public            postgres    false    210            c           2606    41121    itens itemidpk 
   CONSTRAINT     P   ALTER TABLE ONLY public.itens
    ADD CONSTRAINT itemidpk PRIMARY KEY (itemid);
 8   ALTER TABLE ONLY public.itens DROP CONSTRAINT itemidpk;
       public            postgres    false    208            [           2606    49589    login loginpk 
   CONSTRAINT     P   ALTER TABLE ONLY public.login
    ADD CONSTRAINT loginpk PRIMARY KEY (loginid);
 7   ALTER TABLE ONLY public.login DROP CONSTRAINT loginpk;
       public            postgres    false    201            a           2606    49354    quartos quartopk 
   CONSTRAINT     R   ALTER TABLE ONLY public.quartos
    ADD CONSTRAINT quartopk PRIMARY KEY (quarto);
 :   ALTER TABLE ONLY public.quartos DROP CONSTRAINT quartopk;
       public            postgres    false    206            _           2606    41084    reservas reservaidpk 
   CONSTRAINT     Y   ALTER TABLE ONLY public.reservas
    ADD CONSTRAINT reservaidpk PRIMARY KEY (reservaid);
 >   ALTER TABLE ONLY public.reservas DROP CONSTRAINT reservaidpk;
       public            postgres    false    205            ]           2606    49576    usuario usuariopk 
   CONSTRAINT     V   ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuariopk PRIMARY KEY (usuarioid);
 ;   ALTER TABLE ONLY public.usuario DROP CONSTRAINT usuariopk;
       public            postgres    false    203            j           2606    49577    login fk_usuario    FK CONSTRAINT     {   ALTER TABLE ONLY public.login
    ADD CONSTRAINT fk_usuario FOREIGN KEY (fk_usuario) REFERENCES public.usuario(usuarioid);
 :   ALTER TABLE ONLY public.login DROP CONSTRAINT fk_usuario;
       public          postgres    false    2909    203    201            o           2606    49347    consumos item_fk    FK CONSTRAINT     r   ALTER TABLE ONLY public.consumos
    ADD CONSTRAINT item_fk FOREIGN KEY (itemfk) REFERENCES public.itens(itemid);
 :   ALTER TABLE ONLY public.consumos DROP CONSTRAINT item_fk;
       public          postgres    false    208    2915    214            l           2606    41109    quartos reserva_fk    FK CONSTRAINT     }   ALTER TABLE ONLY public.quartos
    ADD CONSTRAINT reserva_fk FOREIGN KEY (reservafk) REFERENCES public.reservas(reservaid);
 <   ALTER TABLE ONLY public.quartos DROP CONSTRAINT reserva_fk;
       public          postgres    false    206    205    2911            n           2606    49342    consumos reserva_fk    FK CONSTRAINT     ~   ALTER TABLE ONLY public.consumos
    ADD CONSTRAINT reserva_fk FOREIGN KEY (reservafk) REFERENCES public.reservas(reservaid);
 =   ALTER TABLE ONLY public.consumos DROP CONSTRAINT reserva_fk;
       public          postgres    false    214    205    2911            m           2606    49582    cartao usuario_fk    FK CONSTRAINT     {   ALTER TABLE ONLY public.cartao
    ADD CONSTRAINT usuario_fk FOREIGN KEY (usuariofk) REFERENCES public.usuario(usuarioid);
 ;   ALTER TABLE ONLY public.cartao DROP CONSTRAINT usuario_fk;
       public          postgres    false    2909    203    212            k           2606    57897    reservas usuariofk    FK CONSTRAINT     |   ALTER TABLE ONLY public.reservas
    ADD CONSTRAINT usuariofk FOREIGN KEY (usuariofk) REFERENCES public.usuario(usuarioid);
 <   ALTER TABLE ONLY public.reservas DROP CONSTRAINT usuariofk;
       public          postgres    false    205    2909    203            �   �   x�M�1�0@��9E/`p��Ѣ�����T���r�n��?�8"�xL����R[5X�H��AE��Y&�!�포HL	�"4�|��/��V$J����{~N���|�5 �F���|�V�֏��:n���5���9���()          i   x�m�=
�0��"���b��v�G�M����Z�af���}����P(�D�D� �uȩ�AHQZ�X�ϑ�T�,vS2_����Ulן!��nj�����      �   @   x�3�N�K)�L�H�44�2�t�ON�u��I�4�2�tN̬HTHIUp��O
��r�r��qqq ��      �   X   x�3�tN̬HTHIUp��O��I,I�44�45�t�,.���,K��2�t�ON�uJs���P�9��RJ3�3���A
����c���� ���      �   E   x�3�t�M�KI�442615����tL����4�2�H,)�L��"k�e��S�Y��s��r��qqq ��      �   }   x�s4���-�I-�4�4��O.-HL����8}J+�9��d�8���2�C &c�id�1Eȸd��^[�����id�6���]��)P�9�Rctic������n��W� ��;�      �   �   x�mϱj�0���~�Ig%�]J��)�5� �en�>}��Ī������?�G�a��>�S�&l�m	Do�g��q��A�Ȟ��ZC�p�W�\��"x��O򞊺�ؓ���d�6����$��S
��at4��y��������{�ry��)^���:�Q�/�;o]=�L�g���_�U�.am1{�����V��"�憮��]uv(VWY��J�r �      �     x�}νN�0����aH�8iƈ
���J��XN�A'�6��}��J��:�����������h�$��D�~	�.T)��ڼ�;����27��<.�Ql1B�R�J��G���{���%迿���2��h��ZC�m3{�#�+P�4�~��XYms{��0�b�:p�itb�)�ZJ�����q�8n�q��œ󑎋��C�nB&�BIYԍ����L�u���89Ж�q����>C����cUW�v�K�VdY�,zs(     