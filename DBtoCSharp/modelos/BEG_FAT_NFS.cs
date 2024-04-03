
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FAT_NFS
    {
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string REGERAR_NFE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ACEITE_ENTRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// CIAP
        /// </summary>
        public int VLR_INFORMADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_RECIBO_ID { get; set; }
            [Required]
        /// <summary>
        /// DIFAL - UF do destinatario
        /// </summary>
        public int VFCPUFDEST { get; set; }
            [Required]
        /// <summary>
        /// DIFAL - ICMS UF do destinatario
        /// </summary>
        public int VICMSUFDEST { get; set; }
            [Required]
        /// <summary>
        /// DIFAL - ICMS UF do  remetente
        /// </summary>
        public int VICMSUFREMET { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se a Nota foi manifestada
        /// </summary>
        public string IND_MANIFESTO { get; set; }
        
        /// <summary>
        /// ID do manifesto gerado
        /// </summary>
        public int DIE_MAN_TRANSPORTE_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica se a NF foi faturada para a conveniada com emissao de CFOP 5929
        /// </summary>
        public string IND_NF_CONVENIADA { get; set; }
        
        /// <summary>
        /// Indica o processo que gerou NF faturada para a conveniada com emissao de CFOP 5929
        /// </summary>
        public int DIE_NFE_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// Tabela de classificacao do codigo de tributacao no municipio.
        /// </summary>
        public int DIE_ISSQN_SUBITEM_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ISSQN_RETIDO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Chave de acesso da nf ou cupom eletronico
        /// </summary>
        public string CHAVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_ROTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PLANO_VENDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQ_IRRF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASE_IRRF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQ_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASE_ISSQN { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Nr associado Convenio
        /// </summary>
        public string NRO_ASSOCIADO { get; set; }
        
        /// <summary>
        /// Id da financeira - 07/01/2009 - AOK
        /// </summary>
        public int DIE_FIN_FINANCEIRA_ID { get; set; }
        
        /// <summary>
        /// Id do convenio - 07/01/2009 - AOK
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// Id do vendedor - 07/01/2009 - AOK
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
        
        /// <summary>
        /// Valor do desconto aplicado na nota
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// Valor total dqa garantia
        /// </summary>
        public int VL_GARANTIA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica tipo da devolução de compra P-parcial, T-total
        /// </summary>
        public string TP_DEVOLUCAO { get; set; }
        
        /// <summary>
        /// data liberação nota transf 
        /// </summary>
        public string DT_LIBERACAO { get; set; }
        
        /// <summary>
        /// id do usuário que liberou a nf
        /// </summary>
        public int BEG_APEX_USER_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Y/N
        /// </summary>
        public string LIBERADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_COFINS { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string PROTOCOLO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id da nota fiscal de saida
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da Filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo - Yes / No
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// Data da criacao do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Id do usuario que criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da ultima alteracao do registro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Id do usuario que fez a ultima alteracao registro
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Numero da Nota fiscal de Saida
        /// </summary>
        public int NRO_NFS { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Serie da Nota Fiscal
        /// </summary>
        public string SERIE_NFS { get; set; }
            [Required]
        /// <summary>
        /// Data de emissao
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// Numero da duplicata da nota fiscal de saida
        /// </summary>
        public int NRO_DUPLICATA { get; set; }
            [Required]
        /// <summary>
        /// Percentual de icms
        /// </summary>
        public int PERC_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor de base de calculo do icms
        /// </summary>
        public int VL_BASE_CALCULO_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor da base isenta de icms
        /// </summary>
        public int VL_BASE_ISENTA_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor da base outras icms
        /// </summary>
        public int VL_BASE_OUTRAS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor do ICMS
        /// </summary>
        public int VL_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor da base de calculo do IPI
        /// </summary>
        public int VL_BASE_CALCULO_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor base de isentos do IPI
        /// </summary>
        public int VL_BASE_ISENTA_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor base outras do IPI
        /// </summary>
        public int VL_BASE_OUTRAS_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor do IPI
        /// </summary>
        public int VL_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor base do icms substituição tributaria
        /// </summary>
        public int VL_BASE_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// Valor do ICMS substituição tributaria
        /// </summary>
        public int VL_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// Valor total do frete
        /// </summary>
        public int VL_FRETE { get; set; }
            [Required]
        /// <summary>
        /// Valor do seguro
        /// </summary>
        public int VL_SEGURO { get; set; }
            [Required]
        /// <summary>
        /// Valor de outras despesas
        /// </summary>
        public int VL_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto
        /// </summary>
        public int PERC_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// Valor total dos produtos
        /// </summary>
        public int VL_TOTAL_PROD { get; set; }
            [Required]
        /// <summary>
        /// Valor total da Nota fiscal de saida
        /// </summary>
        public int VL_TOTAL_NFS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Placa do veiculo
        /// </summary>
        public string PLACA_VEICULO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Unidade federativa _ estado
        /// </summary>
        public string UF_VEICULO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Placas do veiculo redespecho
        /// </summary>
        public string PLACA_VEICULO_REDES { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Unidade federativa do veiculo - redespacho
        /// </summary>
        public string UF_VEICULO_REDES { get; set; }
            [Required]
        /// <summary>
        /// Valor do custo financeiro
        /// </summary>
        public int VL_CUSTO_FINANCEIRO { get; set; }
            [Required]
        /// <summary>
        /// Numero do cupon fiscal
        /// </summary>
        public int NRO_CUPON_FISCAL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Numero de serie do ECF
        /// </summary>
        public string SERIE_MAQUINA { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Observações
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// Percentual de comissão do pedido
        /// </summary>
        public int PERC_COMISSAO_PEDIDO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Integrado (s/n)
        /// </summary>
        public string INTEGRADO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Faturavel (s/n)
        /// </summary>
        public string FATURAVEL { get; set; }
        
        /// <summary>
        /// Data e hora da saida
        /// </summary>
        public string DT_SAIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTHR_ADORG_ID { get; set; }
            [Required]
        /// <summary>
        /// Valor da despesa financeira
        /// </summary>
        public int VL_DESP_FINANCEIRA { get; set; }
            [Required]
        /// <summary>
        /// Gerado arquivo EDI (s/n)
        /// </summary>
        public string GERADO_ARQ_EDI { get; set; }
            [Required]
        /// <summary>
        /// Cliente/fornecedor (beg_pessoa)
        /// </summary>
        public int BEG_VW_PESSOA_ENTREGA_ID { get; set; }
        
        /// <summary>
        /// Codigo do representante (beg_pessoa)
        /// </summary>
        public int BEG_VW_REPRESENTANTE_ID { get; set; }
        
        /// <summary>
        /// Codigo da Transportadora (beg_pessoa)
        /// </summary>
        public int BEG_VW_TRANSPORTADORA_ID { get; set; }
        
        /// <summary>
        /// Codigo da transp redespacho (beg_pessoa)
        /// </summary>
        public int BEG_VW_REDESPACHO_ID { get; set; }
        
        /// <summary>
        /// Ida da condicao de pagamento
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// Id do banco
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// Id do CFOP
        /// </summary>
        public int BEG_CFOP_ID { get; set; }
            [Required]
        /// <summary>
        /// Id das espécies de nfs referente ao estoque
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
        
        /// <summary>
        /// Valor da comissao do vendedor
        /// </summary>
        public int COMISSAO_VENDEDOR { get; set; }
        
        /// <summary>
        /// Valor da comissao do televendedor
        /// </summary>
        public int COMISSAO_TELEVENDA { get; set; }
        
        /// <summary>
        /// Quantidade de volumes
        /// </summary>
        public int QTDE_VOLUME { get; set; }
        
        /// <summary>
        /// Peso Liquido
        /// </summary>
        public int PESO_LIQUIDO { get; set; }
        
        /// <summary>
        /// Peso Bruto
        /// </summary>
        public int PESO_BRUTO { get; set; }
        
        /// <summary>
        /// Data de  canclamento da Nota fiscal
        /// </summary>
        public string DT_CANCELAMENTO { get; set; }
            [Required]
        /// <summary>
        /// Nota fiscal cancelada Y ou N 
        /// </summary>
        public string CANCELADA { get; set; }
        
        /// <summary>
        /// Id do vendedor
        /// </summary>
        public int BEG_VEN_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// Descricao na Suframa
        /// </summary>
        public int DESC_SUFRAMA { get; set; }
        
        /// <summary>
        /// Id do preposto
        /// </summary>
        public int BEG_VW_PREPOSTO_ID { get; set; }
        
        /// <summary>
        /// Id da tabela Beg_cpg_tpmov 
        /// </summary>
        public int BEG_CPG_TPMOV_ID { get; set; }
        
        /// <summary>
        /// Valor seguros residenciais e pessoal
        /// </summary>
        public int VL_SEGUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_TIPO_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_INSS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_IRRF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FIDC { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_NF_FIDC { get; set; }
        
        /// <summary>
        /// Id do Pedido da loja
        /// </summary>
        public int DIE_PEDIDO_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_BI_FAT_NFS_SITE { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n  if inserting and :new.ad_org_id = 1000134 then\n  \n    insert into die_controle_transp_site\n      (DIE_CONTROLE_TRANSP_SITE_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       VALUE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       BEG_FAT_NFS_ID,\n       DT_EMISSAO,\n       BEG_PESSOA_ID,\n       QTDE_VOLUME,\n       BEG_VW_TRANSPORTADORA_ID,\n       PESO,\n       VLR_TOTAL,\n       VLR_FRETE)\n    values\n    \n      (beg_fnc_ad_sequence('DIE_CONTROLE_TRANSP_SITE'),\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID,\n       :NEW.ISACTIVE,\n       :NEW.NRO_NFS,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       :NEW.BEG_FAT_NFS_ID,\n       :NEW.DT_EMISSAO,\n       :NEW.BEG_VW_PESSOA_ENTREGA_ID,\n       :NEW.QTDE_VOLUME,\n       :NEW.BEG_VW_TRANSPORTADORA_ID,\n       :NEW.Peso_Bruto,\n       :NEW.VL_TOTAL_NFS,\n       :NEW.VL_FRETE);\n  \n  end if;\n\nend die_bi_fat_nfs_site;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_TRANSF_ESTE { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  -- local variables here\n  cursor busca_itens is\n    select *\n    from   beg_fat_nfs_item i\n    where  beg_fat_nfs_id = :new.beg_fat_nfs_id;\n  --\n  v_itens  busca_itens%rowtype;\n  --\n  CURSOR BUSCA_ALMOXARIFADO IS \n    SELECT beg_fnc_retorna_parametro(D.AD_CLIENT_ID,D.AD_ORG_ID,'Vendas','Faturamento','ALMOXARIFADO FATURAMENTO') almoxarifado_id\n    FROM   BEG_DADO_FILIAL D\n    WHERE  D.BEG_PESSOA_ID = :NEW.BEG_VW_PESSOA_ENTREGA_ID;\n  --\n  v_almoxarifado_id number(10);\n  v_sequence        number(10);\n  --\n  cursor busca_usuario is \n    select u.ind_separador,\n           u.beg_apex_user_id\n    from   beg_apex_user u \n    where  u.ad_user_id = :new.updatedby;\n  --\n  v_usuario  busca_usuario%rowtype;\n  --\n  cursor busca_filial is\n    select value\n    from   beg_dado_filial f\n    where  f.ad_org_id = :new.ad_org_id;\n  --\n  v_origem varchar2(100);\n  --\nbegin\n  --\n  :new.dt_emissao := trunc(:new.dt_emissao);\n  --\n\n  if :new.liberado = 'Y' and nvl(:old.liberado,'N') = 'N' THEN\n    if :new.beg_apex_user_id is null then\n      open busca_usuario;\n      fetch busca_usuario into v_usuario;\n      close busca_usuario;\n      if v_usuario.ind_separador <> 'Y'  then\n        raise_application_error(-20501,'Usuario nao autorizado a liberar nota.');\n      end if;\n      :new.beg_apex_user_id := v_usuario.beg_apex_user_id;\n    end if;\n    if :new.dt_liberacao is null then \n      :new.dt_liberacao := sysdate;\n    end if;\n    open busca_almoxarifado;\n    fetch BUSCA_ALMOXARIFADO into v_almoxarifado_id;\n    close BUSCA_ALMOXARIFADO;\n    open busca_filial;\n    fetch busca_filial into v_origem;\n    close busca_filial;\n    open busca_itens;\n    loop\n      fetch busca_itens into v_itens;\n      exit when busca_itens%notfound;\n      --\n      Ad_Sequence_Next('BEG_EST_MOVTO_ESTOQUE',\n                 1000000,\n                 v_Sequence);\n      --\n      insert into Beg_Est_Movto_Estoque\n          (Beg_Est_Movto_Estoque_Id,\n           Ad_Client_Id,\n           Ad_Org_Id,\n           Isactive,\n           Created,\n           Createdby,\n           Updated,\n           Updatedby,\n           Beg_Est_Tp_Especie_Id,\n           Beg_Prd_Sku_Id,\n           Beg_Produto_Id,\n           Beg_Est_Almoxarifado_Id,\n           Beg_Est_Vw_Almox_Destino_Id,\n           Vlr_Movto,\n           Qtd_Movto,\n           Documento,\n           data)\n        values\n          (v_Sequence,\n           :new.Ad_Client_Id,\n           :new.Ad_Org_Id,\n           'Y',\n           :new.dt_liberacao,\n           :new.Createdby,\n           :new.dt_liberacao,\n           :new.Updatedby,\n           2000026,--:new.Beg_Est_Tp_Especie_Id,\n           v_itens.Beg_Prd_Sku_Id,\n           v_itens.Beg_Produto_Id,\n           null,\n           v_almoxarifado_id,\n           v_itens.vl_unitario ,\n           v_itens.qtde,\n           :new.nro_nfs||'-'||to_char(:new.dt_emissao,'dd/mm/rrrr')||' DE F-'||V_ORIGEM,\n           trunc(:new.dt_liberacao));\n    end loop;\n    close busca_itens;\n  END IF;\nend beg_trg_transf_este;\n"}`;
    
    }
}
