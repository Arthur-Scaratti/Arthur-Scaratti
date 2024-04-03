
using Microsoft.EntityFrameworkCore;
using .Modelos;

namespace MyNovelAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<MLOG$_BEG_PRD_FABRICANTE> MLOG_BEG_PRD_FABRICANTE { get; set; }

        public DbSet<MLOG$_BEG_PRD_MARCA> MLOG_BEG_PRD_MARCA { get; set; }

        public DbSet<MLOG$_BEG_PRD_PRECO> MLOG_BEG_PRD_PRECO { get; set; }

        public DbSet<MLOG$_BEG_PRD_PROMOCAO> MLOG_BEG_PRD_PROMOCAO { get; set; }

        public DbSet<MLOG$_BEG_PRD_SKU> MLOG_BEG_PRD_SKU { get; set; }

        public DbSet<MLOG$_BEG_PRD_SKU_DETALHE> MLOG_BEG_PRD_SKU_DETALHE { get; set; }

        public DbSet<MLOG$_BEG_PRODUTO> MLOG_BEG_PRODUTO { get; set; }

        public DbSet<MLOG$_BEG_EST_ALMOXARIFADO> MLOG_BEG_EST_ALMOXARIFADO { get; set; }

        public DbSet<MLOG$_BEG_EST_TP_ALMOXARIF> MLOG_BEG_EST_TP_ALMOXARIF { get; set; }

        public DbSet<MLOG$_BEG_TIPO_TITULO> MLOG_BEG_TIPO_TITULO { get; set; }

        public DbSet<SYS_EXPORT_TABLE_08> SYS_EXPORT_TABLE_08 { get; set; }

        public DbSet<SYS_EXPORT_TABLE_01> SYS_EXPORT_TABLE_01 { get; set; }

        public DbSet<DIE_CONTROLE_AP> DIE_CONTROLE_AP { get; set; }

        public DbSet<BEG_VEN_PEDIDO_CONSOLIDADO> BEG_VEN_PEDIDO_CONSOLIDADO { get; set; }

        public DbSet<BEG_VEN_PEDIDO_ORIGEM> BEG_VEN_PEDIDO_ORIGEM { get; set; }

        public DbSet<DIE_NR_SORTE_BKP> DIE_NR_SORTE_BKP { get; set; }

        public DbSet<DIE_MOTIVO_DEVOL> DIE_MOTIVO_DEVOL { get; set; }

        public DbSet<DIE_VW_TOT_CPG_TMP> DIE_VW_TOT_CPG_TMP { get; set; }

        public DbSet<BEG_CPG_FECH_FORN> BEG_CPG_FECH_FORN { get; set; }

        public DbSet<DIE_CAR_CARTOES_VENCIMENTO> DIE_CAR_CARTOES_VENCIMENTO { get; set; }

        public DbSet<BEG_FAT_PRE_NFS_ITEM> BEG_FAT_PRE_NFS_ITEM { get; set; }

        public DbSet<BEG_FAT_ESPECIE_VOLUME> BEG_FAT_ESPECIE_VOLUME { get; set; }

        public DbSet<BEG_GER_TIPO_FRETE> BEG_GER_TIPO_FRETE { get; set; }

        public DbSet<AD_ORG_BKP> AD_ORG_BKP { get; set; }

        public DbSet<AD_PRINTFORMAT_BKP> AD_PRINTFORMAT_BKP { get; set; }

        public DbSet<BANCO> BANCO { get; set; }

        public DbSet<BANCOS> BANCOS { get; set; }

        public DbSet<BANCOSAGENCIAS> BANCOSAGENCIAS { get; set; }

        public DbSet<BEG_CHQ_HISTORICO> BEG_CHQ_HISTORICO { get; set; }

        public DbSet<BEG_COB_LOTE_COBR> BEG_COB_LOTE_COBR { get; set; }

        public DbSet<BEG_CONVENIO> BEG_CONVENIO { get; set; }

        public DbSet<BEG_CPG_PGTO_MANUAL> BEG_CPG_PGTO_MANUAL { get; set; }

        public DbSet<BEG_CPG_PGTO_MANUAL_DEBITO> BEG_CPG_PGTO_MANUAL_DEBITO { get; set; }

        public DbSet<BEG_CPG_RENEG> BEG_CPG_RENEG { get; set; }

        public DbSet<BEG_CPG_RENEG_FORNECEDOR> BEG_CPG_RENEG_FORNECEDOR { get; set; }

        public DbSet<BEG_CPG_RENEG_PARCELA> BEG_CPG_RENEG_PARCELA { get; set; }

        public DbSet<BEG_CPG_RENEG_TITULO> BEG_CPG_RENEG_TITULO { get; set; }

        public DbSet<BEG_CRC_PARCELA_RENEG> BEG_CRC_PARCELA_RENEG { get; set; }

        public DbSet<BEG_CRC_PESSOA_RENEG> BEG_CRC_PESSOA_RENEG { get; set; }

        public DbSet<BEG_CRC_RENEGOCIACAO> BEG_CRC_RENEGOCIACAO { get; set; }

        public DbSet<BEG_CRC_TITULO_RENEGOCIADO> BEG_CRC_TITULO_RENEGOCIADO { get; set; }

        public DbSet<BEG_FIN_CAIXA_MOVIMENTO> BEG_FIN_CAIXA_MOVIMENTO { get; set; }

        public DbSet<BEG_FIS_TP_NFE> BEG_FIS_TP_NFE { get; set; }

        public DbSet<BEG_FRO_MULTA> BEG_FRO_MULTA { get; set; }

        public DbSet<BEG_FRO_SAIDA_VEICULO> BEG_FRO_SAIDA_VEICULO { get; set; }

        public DbSet<BEG_PCE_LOTE_PAGAMENTO> BEG_PCE_LOTE_PAGAMENTO { get; set; }

        public DbSet<BEG_PCE_LOTE_PAGTO_TIT> BEG_PCE_LOTE_PAGTO_TIT { get; set; }

        public DbSet<DEPT> DEPT { get; set; }

        public DbSet<DNE_GU_BAIRROS> DNE_GU_BAIRROS { get; set; }

        public DbSet<DNE_GU_LOCALIDADES> DNE_GU_LOCALIDADES { get; set; }

        public DbSet<DNE_GU_RS_LOGRADOUROS> DNE_GU_RS_LOGRADOUROS { get; set; }

        public DbSet<DNE_GU_SC_LOGRADOUROS> DNE_GU_SC_LOGRADOUROS { get; set; }

        public DbSet<EMP> EMP { get; set; }

        public DbSet<FORMULA> FORMULA { get; set; }

        public DbSet<GRUPODES> GRUPODES { get; set; }

        public DbSet<GRUPOREC> GRUPOREC { get; set; }

        public DbSet<NBMNCM> NBMNCM { get; set; }

        public DbSet<PLAN_TABLE> PLAN_TABLE { get; set; }

        public DbSet<STORE_BLOB> STORE_BLOB { get; set; }

        public DbSet<SUBDES> SUBDES { get; set; }

        public DbSet<SUBREC> SUBREC { get; set; }

        public DbSet<T_AD_COLUMN> T_AD_COLUMN { get; set; }

        public DbSet<TFLASHBACK> TFLASHBACK { get; set; }

        public DbSet<MLOG$_BEG_PESSOA_ENDERECO> MLOG_BEG_PESSOA_ENDERECO { get; set; }

        public DbSet<MLOG$_BEG_PESSOA_FILIAL> MLOG_BEG_PESSOA_FILIAL { get; set; }

        public DbSet<MLOG$_BEG_PESSOA_OBS> MLOG_BEG_PESSOA_OBS { get; set; }

        public DbSet<MLOG$_BEG_PESSOA_RELACIONA> MLOG_BEG_PESSOA_RELACIONA { get; set; }

        public DbSet<MLOG$_BEG_PESSOA_RESTRICAO> MLOG_BEG_PESSOA_RESTRICAO { get; set; }

        public DbSet<MLOG$_BEG_PESSOA> MLOG_BEG_PESSOA { get; set; }

        public DbSet<MLOG$_BEG_REF_BANCARIA> MLOG_BEG_REF_BANCARIA { get; set; }

        public DbSet<MLOG$_BEG_REF_COMERCIAL> MLOG_BEG_REF_COMERCIAL { get; set; }

        public DbSet<MLOG$_BEG_REF_PESSOAL> MLOG_BEG_REF_PESSOAL { get; set; }

        public DbSet<MLOG$_BEG_RESTRICAO> MLOG_BEG_RESTRICAO { get; set; }

        public DbSet<MLOG$_BEG_TELEFONE> MLOG_BEG_TELEFONE { get; set; }

        public DbSet<BEG_REP_TABELA> BEG_REP_TABELA { get; set; }

        public DbSet<BEG_COB_SIT_CONTATO> BEG_COB_SIT_CONTATO { get; set; }

        public DbSet<GRUPO> GRUPO { get; set; }

        public DbSet<CONVENIO> CONVENIO { get; set; }

        public DbSet<DIE_PRD_GRUPO> DIE_PRD_GRUPO { get; set; }

        public DbSet<MLOG$_BEG_CEP> MLOG_BEG_CEP { get; set; }

        public DbSet<BEG_PRD_CONJUNTO> BEG_PRD_CONJUNTO { get; set; }

        public DbSet<DIE_PRD_SUBGRUPO> DIE_PRD_SUBGRUPO { get; set; }

        public DbSet<DIE_PRD_GARANTIA> DIE_PRD_GARANTIA { get; set; }

        public DbSet<DIE_VEN_LISTA_NOIVA> DIE_VEN_LISTA_NOIVA { get; set; }

        public DbSet<DIE_VEN_LN_PESSOA> DIE_VEN_LN_PESSOA { get; set; }

        public DbSet<DIE_VEN_LN_PRODUTO> DIE_VEN_LN_PRODUTO { get; set; }

        public DbSet<DIE_CRC_BAIXA_MANUAL> DIE_CRC_BAIXA_MANUAL { get; set; }

        public DbSet<DIE_RPL_FILIAL> DIE_RPL_FILIAL { get; set; }

        public DbSet<DEMO_IMAGES> DEMO_IMAGES { get; set; }

        public DbSet<FILIAL> FILIAL { get; set; }

        public DbSet<BEG_PESSOA_FILIAL_GSC> BEG_PESSOA_FILIAL_GSC { get; set; }

        public DbSet<DIE_FIS_ECF_ALIQUOTA_BCK> DIE_FIS_ECF_ALIQUOTA_BCK { get; set; }

        public DbSet<DIE_FIS_ECF_ALIQUOTA> DIE_FIS_ECF_ALIQUOTA { get; set; }

        public DbSet<MLOG$_BEG_CRC_TITULO_ABERT> MLOG_BEG_CRC_TITULO_ABERT { get; set; }

        public DbSet<DIE_VEN_REGIAO> DIE_VEN_REGIAO { get; set; }

        public DbSet<DIE_VEN_META_PREPOSTO> DIE_VEN_META_PREPOSTO { get; set; }

        public DbSet<DIE_VEN_COTA_GRUPO> DIE_VEN_COTA_GRUPO { get; set; }

        public DbSet<DIE_VEN_COTA_GRUPO_PRODUTO> DIE_VEN_COTA_GRUPO_PRODUTO { get; set; }

        public DbSet<BEG_PRD_ATRIBUTO> BEG_PRD_ATRIBUTO { get; set; }

        public DbSet<BEG_PRD_REF_MARCA> BEG_PRD_REF_MARCA { get; set; }

        public DbSet<DIE_PES_FORNECEDOR_BKP> DIE_PES_FORNECEDOR_BKP { get; set; }

        public DbSet<DIE_PES_FORNECEDOR_VINCULO_BKP> DIE_PES_FORNECEDOR_VINCULO_BKP { get; set; }

        public DbSet<ITEPRO_BKP> ITEPRO_BKP { get; set; }

        public DbSet<PROMOCAO_BKP> PROMOCAO_BKP { get; set; }

        public DbSet<BEG_APEX_USER> BEG_APEX_USER { get; set; }

        public DbSet<BEG_PRD_PRECO> BEG_PRD_PRECO { get; set; }

        public DbSet<BEG_APEX_APPLICATION> BEG_APEX_APPLICATION { get; set; }

        public DbSet<BEG_APEX_APPLICATION_TAB> BEG_APEX_APPLICATION_TAB { get; set; }

        public DbSet<BEG_CST_CALCULO> BEG_CST_CALCULO { get; set; }

        public DbSet<BEG_PRD_SKU_ATRIBUTO> BEG_PRD_SKU_ATRIBUTO { get; set; }

        public DbSet<BEG_CEL_OPERADORA> BEG_CEL_OPERADORA { get; set; }

        public DbSet<BEG_CEL_PLANO> BEG_CEL_PLANO { get; set; }

        public DbSet<ECT_LOG_BAIRRO> ECT_LOG_BAIRRO { get; set; }

        public DbSet<ECT_LOG_CONTROLE> ECT_LOG_CONTROLE { get; set; }

        public DbSet<ECT_LOG_CPC> ECT_LOG_CPC { get; set; }

        public DbSet<ECT_LOG_FAIXA_BAIRRO> ECT_LOG_FAIXA_BAIRRO { get; set; }

        public DbSet<ECT_LOG_FAIXA_CPC> ECT_LOG_FAIXA_CPC { get; set; }

        public DbSet<ECT_LOG_FAIXA_LOCALIDADE> ECT_LOG_FAIXA_LOCALIDADE { get; set; }

        public DbSet<ECT_LOG_FAIXA_UF> ECT_LOG_FAIXA_UF { get; set; }

        public DbSet<ECT_LOG_FAIXA_UOP> ECT_LOG_FAIXA_UOP { get; set; }

        public DbSet<ECT_LOG_GRANDE_USUARIO> ECT_LOG_GRANDE_USUARIO { get; set; }

        public DbSet<ECT_LOG_LOCALIDADE> ECT_LOG_LOCALIDADE { get; set; }

        public DbSet<ECT_LOG_LOGRADOURO> ECT_LOG_LOGRADOURO { get; set; }

        public DbSet<ECT_LOG_UNID_OPER> ECT_LOG_UNID_OPER { get; set; }

        public DbSet<ECT_LOG_LOCALIDADE_DNE> ECT_LOG_LOCALIDADE_DNE { get; set; }

        public DbSet<ECT_LOG_LOGRADOURO_DNE> ECT_LOG_LOGRADOURO_DNE { get; set; }

        public DbSet<BEG_DIST_LINHA_SOLICITACAO> BEG_DIST_LINHA_SOLICITACAO { get; set; }

        public DbSet<BEG_GER_PAIS> BEG_GER_PAIS { get; set; }

        public DbSet<PAIS_2LETRAS> PAIS_2LETRAS { get; set; }

        public DbSet<DDI> DDI { get; set; }

        public DbSet<TIPO_RUA> TIPO_RUA { get; set; }

        public DbSet<BEG_GER_UF> BEG_GER_UF { get; set; }

        public DbSet<BEG_GER_LOCALIDADE> BEG_GER_LOCALIDADE { get; set; }

        public DbSet<BEG_GER_BAIRRO> BEG_GER_BAIRRO { get; set; }

        public DbSet<BEG_GER_BAIRRO_FAIXA> BEG_GER_BAIRRO_FAIXA { get; set; }

        public DbSet<DDD_MUNICIPIO> DDD_MUNICIPIO { get; set; }

        public DbSet<DDD_LOCALIDADE> DDD_LOCALIDADE { get; set; }

        public DbSet<BEG_CEL_DESTINO> BEG_CEL_DESTINO { get; set; }

        public DbSet<BEG_CEL_TPMOV> BEG_CEL_TPMOV { get; set; }

        public DbSet<BEG_CEL_ATRIBUTO> BEG_CEL_ATRIBUTO { get; set; }

        public DbSet<BEG_CEL_ATRIBUTO_PLANO> BEG_CEL_ATRIBUTO_PLANO { get; set; }

        public DbSet<BEG_CEL_CODIGO> BEG_CEL_CODIGO { get; set; }

        public DbSet<BEG_COB_SPC_RETORNO> BEG_COB_SPC_RETORNO { get; set; }

        public DbSet<BEG_CEL_LAYOUT> BEG_CEL_LAYOUT { get; set; }

        public DbSet<DIE_CRC_POSICAO_ATRASO_TMP_BKP> DIE_CRC_POSICAO_ATRASO_TMP_BKP { get; set; }

        public DbSet<BEG_CRC_TITULO_VENCIDO_MV> BEG_CRC_TITULO_VENCIDO_MV { get; set; }

        public DbSet<DIE_TITULO_COBRADOR_TMP> DIE_TITULO_COBRADOR_TMP { get; set; }

        public DbSet<SYS_IMPORT_FULL_01> SYS_IMPORT_FULL_01 { get; set; }

        public DbSet<BEG_COBRADOR_CIDADE> BEG_COBRADOR_CIDADE { get; set; }

        public DbSet<BEG_COB_CARTORIO> BEG_COB_CARTORIO { get; set; }

        public DbSet<DIE_GER_DESENV> DIE_GER_DESENV { get; set; }

        public DbSet<BEG_CRC_POSICAO_ATRASO2> BEG_CRC_POSICAO_ATRASO2 { get; set; }

        public DbSet<DIE_GER_OBJETO> DIE_GER_OBJETO { get; set; }

        public DbSet<DIE_GER_SOL_OBJETO> DIE_GER_SOL_OBJETO { get; set; }

        public DbSet<DIE_LOG_LIMPA_DISTRIBUICAO> DIE_LOG_LIMPA_DISTRIBUICAO { get; set; }

        public DbSet<DIE_COB_PESSOA_RESTRICAO> DIE_COB_PESSOA_RESTRICAO { get; set; }

        public DbSet<MLOG$_BEG_COB_PARAMETRO> MLOG_BEG_COB_PARAMETRO { get; set; }

        public DbSet<RELOJA0805> RELOJA0805 { get; set; }

        public DbSet<BEG_CAR_BANDEIRA> BEG_CAR_BANDEIRA { get; set; }

        public DbSet<BEG_CAR_TIPO_VENDA> BEG_CAR_TIPO_VENDA { get; set; }

        public DbSet<BEG_CAR_TPMOV> BEG_CAR_TPMOV { get; set; }

        public DbSet<BEG_FPG_AFASTAMENTO> BEG_FPG_AFASTAMENTO { get; set; }

        public DbSet<BEG_FPG_CENTRO_CUSTO> BEG_FPG_CENTRO_CUSTO { get; set; }

        public DbSet<BEG_FPG_DEPENDENTE> BEG_FPG_DEPENDENTE { get; set; }

        public DbSet<BEG_FPG_FUNCAO> BEG_FPG_FUNCAO { get; set; }

        public DbSet<BEG_FPG_PESSOA_AFAS> BEG_FPG_PESSOA_AFAS { get; set; }

        public DbSet<BEG_FPG_PESSOA_CC> BEG_FPG_PESSOA_CC { get; set; }

        public DbSet<BEG_FPG_PESSOA_FUNCAO> BEG_FPG_PESSOA_FUNCAO { get; set; }

        public DbSet<BEG_FPG_SITUACAO> BEG_FPG_SITUACAO { get; set; }

        public DbSet<BEG_PRD_PRECO_BKPALL_20080311> BEG_PRD_PRECO_BKPALL_20080311 { get; set; }

        public DbSet<BEG_PRD_PRECO_BKPCAT_20080311> BEG_PRD_PRECO_BKPCAT_20080311 { get; set; }

        public DbSet<BEG_PRD_PRECO_BKPREST_20080311> BEG_PRD_PRECO_BKPREST_20080311 { get; set; }

        public DbSet<PRECO_12_03_BKP> PRECO_12_03_BKP { get; set; }

        public DbSet<MLOG$_BEG_COBRADOR> MLOG_BEG_COBRADOR { get; set; }

        public DbSet<DIE_CRC_RENEGOCIACAO> DIE_CRC_RENEGOCIACAO { get; set; }

        public DbSet<BEG_VEN_FORMA_PGTO_RESTR> BEG_VEN_FORMA_PGTO_RESTR { get; set; }

        public DbSet<DIE_COB_GERA_AVISO_LOG> DIE_COB_GERA_AVISO_LOG { get; set; }

        public DbSet<DIE_CRC_CONTRATO_AVALISTA> DIE_CRC_CONTRATO_AVALISTA { get; set; }

        public DbSet<BEG_TITULO_COBRADOR_F09OTT> BEG_TITULO_COBRADOR_F09OTT { get; set; }

        public DbSet<BEG_GER_REL_PADRAO> BEG_GER_REL_PADRAO { get; set; }

        public DbSet<BEG_COB_LOTE_ASSESSORIA> BEG_COB_LOTE_ASSESSORIA { get; set; }

        public DbSet<BEG_COB_LOTE_ASSESSORIA_TIT> BEG_COB_LOTE_ASSESSORIA_TIT { get; set; }

        public DbSet<DIE_COB_REFLEXO_COBRANCA> DIE_COB_REFLEXO_COBRANCA { get; set; }

        public DbSet<BEG_COB_COBR_RETORNO> BEG_COB_COBR_RETORNO { get; set; }

        public DbSet<PRD_ACERTO_CODIGO> PRD_ACERTO_CODIGO { get; set; }

        public DbSet<DIE_PRD_GERADOR_COR> DIE_PRD_GERADOR_COR { get; set; }

        public DbSet<BEG_COBRADOR_FILIAL_BKP> BEG_COBRADOR_FILIAL_BKP { get; set; }

        public DbSet<BEG_APEX_USER_TST> BEG_APEX_USER_TST { get; set; }

        public DbSet<PRD_TESTE> PRD_TESTE { get; set; }

        public DbSet<FINANCEIRA> FINANCEIRA { get; set; }

        public DbSet<DIE_FIN_FINANCEIRA> DIE_FIN_FINANCEIRA { get; set; }

        public DbSet<VENDEDOR_1108> VENDEDOR_1108 { get; set; }

        public DbSet<BEG_FPG_DESLIGTO_ESTAGIO> BEG_FPG_DESLIGTO_ESTAGIO { get; set; }

        public DbSet<BEG_GER_TP_PES_REL> BEG_GER_TP_PES_REL { get; set; }

        public DbSet<DIE_FPG_FUNCAO_CBO> DIE_FPG_FUNCAO_CBO { get; set; }

        public DbSet<DIE_CARGA_DIARIO_FORNEC> DIE_CARGA_DIARIO_FORNEC { get; set; }

        public DbSet<DIE_FPG_PARAMETRO> DIE_FPG_PARAMETRO { get; set; }

        public DbSet<BEG_PARAMETRO_SISTEMA_BKP> BEG_PARAMETRO_SISTEMA_BKP { get; set; }

        public DbSet<BEG_GER_FERIADO> BEG_GER_FERIADO { get; set; }

        public DbSet<BEG_MONITOR01> BEG_MONITOR01 { get; set; }

        public DbSet<BEG_HST_NOTA_FISCAL> BEG_HST_NOTA_FISCAL { get; set; }

        public DbSet<BEG_HST_NF_VINCULADA> BEG_HST_NF_VINCULADA { get; set; }

        public DbSet<DIE_CAR_TAXA> DIE_CAR_TAXA { get; set; }

        public DbSet<NOP_DBF> NOP_DBF { get; set; }

        public DbSet<SYS_EXPORT_TABLE_05> SYS_EXPORT_TABLE_05 { get; set; }

        public DbSet<BKN_ORDEM_ASSISTENCIA> BKN_ORDEM_ASSISTENCIA { get; set; }

        public DbSet<BKN_ORDEM_ASSIS_ACOMP> BKN_ORDEM_ASSIS_ACOMP { get; set; }

        public DbSet<SALDO_ESTOFADOS> SALDO_ESTOFADOS { get; set; }

        public DbSet<DIE_CTB_OUTRAS_ENTRADAS_ITEM> DIE_CTB_OUTRAS_ENTRADAS_ITEM { get; set; }

        public DbSet<DIE_CONTROLE_APROVACAO> DIE_CONTROLE_APROVACAO { get; set; }

        public DbSet<BEG_FECH_CONTABIL> BEG_FECH_CONTABIL { get; set; }

        public DbSet<BEG_CHQ_REAPRESENTACAO> BEG_CHQ_REAPRESENTACAO { get; set; }

        public DbSet<BKN_FAT_ESP> BKN_FAT_ESP { get; set; }

        public DbSet<DIE_CRC_RECIBO> DIE_CRC_RECIBO { get; set; }

        public DbSet<BEG_FAT_DEVOLUCAO> BEG_FAT_DEVOLUCAO { get; set; }

        public DbSet<BEG_FAT_DEVOLUCAO_ITEM> BEG_FAT_DEVOLUCAO_ITEM { get; set; }

        public DbSet<BEG_CPG_BAIXA_DEV_ORIGEM> BEG_CPG_BAIXA_DEV_ORIGEM { get; set; }

        public DbSet<DIE_CARTAO_PARCELA_LJ> DIE_CARTAO_PARCELA_LJ { get; set; }

        public DbSet<IVE_F9294> IVE_F9294 { get; set; }

        public DbSet<SYS_EXPORT_TABLE_04> SYS_EXPORT_TABLE_04 { get; set; }

        public DbSet<SYS_EXPORT_TABLE_11> SYS_EXPORT_TABLE_11 { get; set; }

        public DbSet<BEG_CPG_RESUMO_CONTA> BEG_CPG_RESUMO_CONTA { get; set; }

        public DbSet<DIE_CONTROLE_VP> DIE_CONTROLE_VP { get; set; }

        public DbSet<ST_RECUPERAR> ST_RECUPERAR { get; set; }

        public DbSet<SYS_EXPORT_TABLE_10> SYS_EXPORT_TABLE_10 { get; set; }

        public DbSet<DIE_EST_INV_TOTAIS> DIE_EST_INV_TOTAIS { get; set; }

        public DbSet<BEG_FAT_DEV_FORNECEDOR> BEG_FAT_DEV_FORNECEDOR { get; set; }

        public DbSet<BEG_FAT_DEV_FORNECEDOR_ITEM> BEG_FAT_DEV_FORNECEDOR_ITEM { get; set; }

        public DbSet<RESERVA_IMP> RESERVA_IMP { get; set; }

        public DbSet<DIE_DIFAL_ALIQ> DIE_DIFAL_ALIQ { get; set; }

        public DbSet<BEG_CPG_DOC_LOTE_MANUAL> BEG_CPG_DOC_LOTE_MANUAL { get; set; }

        public DbSet<BEG_FIS_CST_PIS> BEG_FIS_CST_PIS { get; set; }

        public DbSet<BEG_FIS_CST_IPI> BEG_FIS_CST_IPI { get; set; }

        public DbSet<BEG_FIS_CST_COFINS> BEG_FIS_CST_COFINS { get; set; }

        public DbSet<DIE_CHAMADO_SITE> DIE_CHAMADO_SITE { get; set; }

        public DbSet<DIE_PADRAO_LOJA> DIE_PADRAO_LOJA { get; set; }

        public DbSet<DIE_PRD_SUB_MAXIMO> DIE_PRD_SUB_MAXIMO { get; set; }

        public DbSet<DIE_PRD_PROD_MAXIMO> DIE_PRD_PROD_MAXIMO { get; set; }

        public DbSet<DIE_PADRAO_LJ_FILIAIS> DIE_PADRAO_LJ_FILIAIS { get; set; }

        public DbSet<BEG_TITULO_COBRADOR_JE> BEG_TITULO_COBRADOR_JE { get; set; }

        public DbSet<PLANOCAIXA_DBF> PLANOCAIXA_DBF { get; set; }

        public DbSet<PLANOBANCOS_DBF> PLANOBANCOS_DBF { get; set; }

        public DbSet<PORTADOR_DBF> PORTADOR_DBF { get; set; }

        public DbSet<DIE_CONTA_CONTABIL_BKP> DIE_CONTA_CONTABIL_BKP { get; set; }

        public DbSet<DIE_CONTA_CONTABIL> DIE_CONTA_CONTABIL { get; set; }

        public DbSet<ITEVEN_DBF> ITEVEN_DBF { get; set; }

        public DbSet<DIE_PARAMETROS> DIE_PARAMETROS { get; set; }

        public DbSet<DIE_EST_ACERTO_ESTOQUE_ITEM> DIE_EST_ACERTO_ESTOQUE_ITEM { get; set; }

        public DbSet<DIE_EST_ACERTO_ESTOQUE> DIE_EST_ACERTO_ESTOQUE { get; set; }

        public DbSet<DIE_TP_ENTREGA> DIE_TP_ENTREGA { get; set; }

        public DbSet<DIE_PES_BONUS_VENDA> DIE_PES_BONUS_VENDA { get; set; }

        public DbSet<DIE_PRD_BRINDE> DIE_PRD_BRINDE { get; set; }

        public DbSet<BKN_VW_ESTOQUE_TRANSITO> BKN_VW_ESTOQUE_TRANSITO { get; set; }

        public DbSet<BKN_VW_RESERVA_FILIAL> BKN_VW_RESERVA_FILIAL { get; set; }

        public DbSet<DIE_SIM_INDICES> DIE_SIM_INDICES { get; set; }

        public DbSet<LOTE_CLIENTES> LOTE_CLIENTES { get; set; }

        public DbSet<DIE_DEPTO_ADM> DIE_DEPTO_ADM { get; set; }

        public DbSet<LOG_SIMULADOR> LOG_SIMULADOR { get; set; }

        public DbSet<CLIENTES_SMS> CLIENTES_SMS { get; set; }

        public DbSet<CUSTOS_CREDITO_ICMS> CUSTOS_CREDITO_ICMS { get; set; }

        public DbSet<DIE_VEN_META_DIA> DIE_VEN_META_DIA { get; set; }

        public DbSet<DIE_CPG_SALDO_CONTA_BKP> DIE_CPG_SALDO_CONTA_BKP { get; set; }

        public DbSet<JOB_OUTPUT> JOB_OUTPUT { get; set; }

        public DbSet<CARTEIRA_VENDIDA2_DBF> CARTEIRA_VENDIDA2_DBF { get; set; }

        public DbSet<HTMLDB_PLAN_TABLE> HTMLDB_PLAN_TABLE { get; set; }

        public DbSet<DIE_CRC_POS_COMIS_SERV> DIE_CRC_POS_COMIS_SERV { get; set; }

        public DbSet<DIE_CARGA_DIARIO_FOR_2023> DIE_CARGA_DIARIO_FOR_2023 { get; set; }

        public DbSet<DIE_REL_CONVENIO_TMP> DIE_REL_CONVENIO_TMP { get; set; }

        public DbSet<DIE_FIN_NF_CONTRATOS> DIE_FIN_NF_CONTRATOS { get; set; }

        public DbSet<DIE_NOTION> DIE_NOTION { get; set; }

        public DbSet<DIE_FIN_CREDITO_BANCARIO> DIE_FIN_CREDITO_BANCARIO { get; set; }

        public DbSet<DIE_FIN_LOTE_CRED_BANC> DIE_FIN_LOTE_CRED_BANC { get; set; }

        public DbSet<BLOB_TEST> BLOB_TEST { get; set; }

        public DbSet<DIE_FIN_DEP_CRED_BANC> DIE_FIN_DEP_CRED_BANC { get; set; }

        public DbSet<SALDO_SET_2022> SALDO_SET_2022 { get; set; }

        public DbSet<DIE_FAT_NFS_CORRECAO> DIE_FAT_NFS_CORRECAO { get; set; }

        public DbSet<PROD_PROMO> PROD_PROMO { get; set; }

        public DbSet<DIE_FILE_BROWSER> DIE_FILE_BROWSER { get; set; }

        public DbSet<DIE_CARGA_DIARIO_CLI_2023> DIE_CARGA_DIARIO_CLI_2023 { get; set; }

        public DbSet<CARTEIRA_VENDIDA> CARTEIRA_VENDIDA { get; set; }

        public DbSet<CARTEIRA_OBITOS> CARTEIRA_OBITOS { get; set; }

        public DbSet<CARTEIRA_PROC_JUDICIAIS> CARTEIRA_PROC_JUDICIAIS { get; set; }

        public DbSet<DIE_FILE_BROWSER_NOMES> DIE_FILE_BROWSER_NOMES { get; set; }

        public DbSet<DIE_VW_PROD_XMLS_ENT_VM> DIE_VW_PROD_XMLS_ENT_VM { get; set; }

        public DbSet<BEG_VEN_CONV_REC_LOT_I_LOG> BEG_VEN_CONV_REC_LOT_I_LOG { get; set; }

        public DbSet<SYS_EXPORT_SCHEMA_01> SYS_EXPORT_SCHEMA_01 { get; set; }

        public DbSet<DIE_PRD_AVARIA> DIE_PRD_AVARIA { get; set; }

        public DbSet<CHEQUES_JT> CHEQUES_JT { get; set; }

        public DbSet<CLIENTEORA> CLIENTEORA { get; set; }

        public DbSet<VENDEDOR_TS> VENDEDOR_TS { get; set; }

        public DbSet<DIE_PRD_NCM> DIE_PRD_NCM { get; set; }

        public DbSet<DIE_CORRELACAO_NBM_NCM> DIE_CORRELACAO_NBM_NCM { get; set; }

        public DbSet<BEG_CIDADE_AOK> BEG_CIDADE_AOK { get; set; }

        public DbSet<DIE_CHK_LIST> DIE_CHK_LIST { get; set; }

        public DbSet<DIE_CHK_LIST_ITEM> DIE_CHK_LIST_ITEM { get; set; }

        public DbSet<PLANO_MF> PLANO_MF { get; set; }

        public DbSet<PLANOEZA_DBF> PLANOEZA_DBF { get; set; }

        public DbSet<NCM_MARCELO> NCM_MARCELO { get; set; }

        public DbSet<BEG_FIS_COD_MODELO> BEG_FIS_COD_MODELO { get; set; }

        public DbSet<PRODUTO_NCM> PRODUTO_NCM { get; set; }

        public DbSet<BEG_CHQ_CHEQUE> BEG_CHQ_CHEQUE { get; set; }

        public DbSet<BEG_VW_BANCO_CUSTODIA> BEG_VW_BANCO_CUSTODIA { get; set; }

        public DbSet<AGENCIASATIVAS> AGENCIASATIVAS { get; set; }

        public DbSet<AGENCIAS> AGENCIAS { get; set; }

        public DbSet<BEG_FIN_BCO_CONTA> BEG_FIN_BCO_CONTA { get; set; }

        public DbSet<DIE_SALDOINV> DIE_SALDOINV { get; set; }

        public DbSet<DIE_NFE_IMPORTADA> DIE_NFE_IMPORTADA { get; set; }

        public DbSet<DIE_NFE_IMPORTADA_ITEM> DIE_NFE_IMPORTADA_ITEM { get; set; }

        public DbSet<DEMO_USERS> DEMO_USERS { get; set; }

        public DbSet<DEMO_CUSTOMERS> DEMO_CUSTOMERS { get; set; }

        public DbSet<DEMO_ORDERS> DEMO_ORDERS { get; set; }

        public DbSet<DEMO_PRODUCT_INFO> DEMO_PRODUCT_INFO { get; set; }

        public DbSet<DEMO_ORDER_ITEMS> DEMO_ORDER_ITEMS { get; set; }

        public DbSet<DEMO_STATES> DEMO_STATES { get; set; }

        public DbSet<DEMO_PAGE_HIERARCHY> DEMO_PAGE_HIERARCHY { get; set; }

        public DbSet<BEG_PRD_GPR_FORN> BEG_PRD_GPR_FORN { get; set; }

        public DbSet<BEG_PRD_GPR_FORN_FORNEC> BEG_PRD_GPR_FORN_FORNEC { get; set; }

        public DbSet<BEG_PRD_INFORMACAO> BEG_PRD_INFORMACAO { get; set; }

        public DbSet<BEG_GPR_DV_PRD_DADO> BEG_GPR_DV_PRD_DADO { get; set; }

        public DbSet<DIE_CRC_RESUMO_RECEITAS> DIE_CRC_RESUMO_RECEITAS { get; set; }

        public DbSet<BEG_PRD_DADOS_VENDA> BEG_PRD_DADOS_VENDA { get; set; }

        public DbSet<BEG_PRD_DADOS_VENDA_VAL> BEG_PRD_DADOS_VENDA_VAL { get; set; }

        public DbSet<BEG_GPR_DADOS_VENDA> BEG_GPR_DADOS_VENDA { get; set; }

        public DbSet<BEG_PRD_DV_VAL_PROD> BEG_PRD_DV_VAL_PROD { get; set; }

        public DbSet<BEG_PRD_NCM_UF> BEG_PRD_NCM_UF { get; set; }

        public DbSet<DIE_CTB_OUTRAS_ENTRADAS> DIE_CTB_OUTRAS_ENTRADAS { get; set; }

        public DbSet<DIE_CTB_RECARGAVIVO> DIE_CTB_RECARGAVIVO { get; set; }

        public DbSet<DIE_GARANTIA> DIE_GARANTIA { get; set; }

        public DbSet<DIE_SUBGRUPO> DIE_SUBGRUPO { get; set; }

        public DbSet<DIE_CAR_CARTOES_BAIXADOS> DIE_CAR_CARTOES_BAIXADOS { get; set; }

        public DbSet<DIE_IEST> DIE_IEST { get; set; }

        public DbSet<SYS_EXPORT_TABLE_03> SYS_EXPORT_TABLE_03 { get; set; }

        public DbSet<DIE_CTB_PISCOFINS> DIE_CTB_PISCOFINS { get; set; }

        public DbSet<DIE_CHEQUES_NCOMP> DIE_CHEQUES_NCOMP { get; set; }

        public DbSet<SYS_EXPORT_TABLE_06> SYS_EXPORT_TABLE_06 { get; set; }

        public DbSet<DIE_DEPOSITOS_IDENTI> DIE_DEPOSITOS_IDENTI { get; set; }

        public DbSet<DIE_ABERTO> DIE_ABERTO { get; set; }

        public DbSet<DIE_ADTO_PGTO> DIE_ADTO_PGTO { get; set; }

        public DbSet<DIE_NR_SORTE_BKP1> DIE_NR_SORTE_BKP1 { get; set; }

        public DbSet<DIE_NR_SORTE> DIE_NR_SORTE { get; set; }

        public DbSet<BEG_PRD_FILIAL> BEG_PRD_FILIAL { get; set; }

        public DbSet<BEG_PRD_PROD_CAIXA> BEG_PRD_PROD_CAIXA { get; set; }

        public DbSet<SALDO_MOVEIS> SALDO_MOVEIS { get; set; }

        public DbSet<SYS_EXPORT_TABLE_02> SYS_EXPORT_TABLE_02 { get; set; }

        public DbSet<BEG_FIN_BCO_SALDO_TRANSFERE> BEG_FIN_BCO_SALDO_TRANSFERE { get; set; }

        public DbSet<BEG_FIN_BCO_MOVTO_TRANSF> BEG_FIN_BCO_MOVTO_TRANSF { get; set; }

        public DbSet<BEG_CPG_BAIXA_DEV> BEG_CPG_BAIXA_DEV { get; set; }

        public DbSet<SYS_EXPORT_TABLE_09> SYS_EXPORT_TABLE_09 { get; set; }

        public DbSet<BEG_PRE_CRC_TITULO> BEG_PRE_CRC_TITULO { get; set; }

        public DbSet<BEG_CPG_RESUMO_CONTA_TOT> BEG_CPG_RESUMO_CONTA_TOT { get; set; }

        public DbSet<DIE_GAR_APOLICE> DIE_GAR_APOLICE { get; set; }

        public DbSet<DIE_RES_APOLICE> DIE_RES_APOLICE { get; set; }

        public DbSet<DIE_PF_APOLICE> DIE_PF_APOLICE { get; set; }

        public DbSet<BKN_LISTA_REFERENCIA_BKP> BKN_LISTA_REFERENCIA_BKP { get; set; }

        public DbSet<BEG_VEN_LINHA_PEDIDO_LOG> BEG_VEN_LINHA_PEDIDO_LOG { get; set; }

        public DbSet<DIE_VENDAS_RECEBIMENTOS> DIE_VENDAS_RECEBIMENTOS { get; set; }

        public DbSet<DIE_CTB_DEMONSTRATIVO> DIE_CTB_DEMONSTRATIVO { get; set; }

        public DbSet<DIE_CRC_RECEITAS> DIE_CRC_RECEITAS { get; set; }

        public DbSet<BEG_CRC_PGTO_MANUAL_FORNEC> BEG_CRC_PGTO_MANUAL_FORNEC { get; set; }

        public DbSet<DIE_CHEQUES_COMP> DIE_CHEQUES_COMP { get; set; }

        public DbSet<BKN_AGRUPA_ENTRADA> BKN_AGRUPA_ENTRADA { get; set; }

        public DbSet<LOB_TABLE> LOB_TABLE { get; set; }

        public DbSet<LOB_TABLE1> LOB_TABLE1 { get; set; }

        public DbSet<BEG_PRD_IMAGEM> BEG_PRD_IMAGEM { get; set; }

        public DbSet<DIE_MAN_TRANSPORTE> DIE_MAN_TRANSPORTE { get; set; }

        public DbSet<DIE_MAN_TRANSPORTE_NF> DIE_MAN_TRANSPORTE_NF { get; set; }

        public DbSet<DIE_ID_PESS_TEMP> DIE_ID_PESS_TEMP { get; set; }

        public DbSet<BEG_FAT_NFE_XML> BEG_FAT_NFE_XML { get; set; }

        public DbSet<CARTAO> CARTAO { get; set; }

        public DbSet<BEG_PCE_PORTADOR_LOTE> BEG_PCE_PORTADOR_LOTE { get; set; }

        public DbSet<BEG_CPG_DOC_LOTE_MAN> BEG_CPG_DOC_LOTE_MAN { get; set; }

        public DbSet<BEG_CHQ_PGTO_MAN> BEG_CHQ_PGTO_MAN { get; set; }

        public DbSet<DIE_VW_TAB_ALIQ_IMP_TMP> DIE_VW_TAB_ALIQ_IMP_TMP { get; set; }

        public DbSet<DIE_CONTROLE_VD> DIE_CONTROLE_VD { get; set; }

        public DbSet<BEG_FAT_CTE_XML> BEG_FAT_CTE_XML { get; set; }

        public DbSet<DIE_NR_SORTE_NEW> DIE_NR_SORTE_NEW { get; set; }

        public DbSet<BEG_VEN_CONV_REC_FAT_LOT> BEG_VEN_CONV_REC_FAT_LOT { get; set; }

        public DbSet<BEG_VEN_CONV_R_F_LOT_ITEM> BEG_VEN_CONV_R_F_LOT_ITEM { get; set; }

        public DbSet<SYS_EXPORT_TABLE_07> SYS_EXPORT_TABLE_07 { get; set; }

        public DbSet<BEG_CPR_CFR_NFE> BEG_CPR_CFR_NFE { get; set; }

        public DbSet<DIE_CTB_TRANSFERENCIAS> DIE_CTB_TRANSFERENCIAS { get; set; }

        public DbSet<BEG_DADO_CONTABIL> BEG_DADO_CONTABIL { get; set; }

        public DbSet<DIE_CONCILIACAO_CIELO> DIE_CONCILIACAO_CIELO { get; set; }

        public DbSet<DIE_AUT_DESPESA> DIE_AUT_DESPESA { get; set; }

        public DbSet<DIE_CAIXA_DESPESA> DIE_CAIXA_DESPESA { get; set; }

        public DbSet<DIE_CAIXA_MOVIMENTO> DIE_CAIXA_MOVIMENTO { get; set; }

        public DbSet<DIE_FIN_CONTRATOS> DIE_FIN_CONTRATOS { get; set; }

        public DbSet<DIE_FIN_CONT_VALIDADE> DIE_FIN_CONT_VALIDADE { get; set; }

        public DbSet<EXCLUIR> EXCLUIR { get; set; }

        public DbSet<DIE_NFE_DESPESAS> DIE_NFE_DESPESAS { get; set; }

        public DbSet<DIE_NFE_DESP_RATEIO> DIE_NFE_DESP_RATEIO { get; set; }

        public DbSet<BEG_TP_NF_CFOP_CONV> BEG_TP_NF_CFOP_CONV { get; set; }

        public DbSet<BEG_TP_NF_VINCULADA> BEG_TP_NF_VINCULADA { get; set; }

        public DbSet<DIE_CRC_POSICAO_TOTAL_CLI> DIE_CRC_POSICAO_TOTAL_CLI { get; set; }

        public DbSet<BEG_PRD_DADOS_VENDA_TMP> BEG_PRD_DADOS_VENDA_TMP { get; set; }

        public DbSet<DIE_ADTO_MVTO> DIE_ADTO_MVTO { get; set; }

        public DbSet<BEG_FAT_PRE_NFS> BEG_FAT_PRE_NFS { get; set; }

        public DbSet<CPFS> CPFS { get; set; }

        public DbSet<DIE_INSTRUCOES> DIE_INSTRUCOES { get; set; }

        public DbSet<DIE_DEPOSITOS_IDENTI_MF> DIE_DEPOSITOS_IDENTI_MF { get; set; }

        public DbSet<DIE_CPG_SALDO_CONTA> DIE_CPG_SALDO_CONTA { get; set; }

        public DbSet<DIE_CONTADOR> DIE_CONTADOR { get; set; }

        public DbSet<DIE_FORMA_PAGTO_VINC> DIE_FORMA_PAGTO_VINC { get; set; }

        public DbSet<DIE_CAR_RESUMO_CARTOES> DIE_CAR_RESUMO_CARTOES { get; set; }

        public DbSet<ACAO_FGTS> ACAO_FGTS { get; set; }

        public DbSet<DIE_VEN_COTA_SUBGRUPO> DIE_VEN_COTA_SUBGRUPO { get; set; }

        public DbSet<DIE_FAT_ESTATISTICA_VENDA> DIE_FAT_ESTATISTICA_VENDA { get; set; }

        public DbSet<DIE_TIPO_CHK_LIST> DIE_TIPO_CHK_LIST { get; set; }

        public DbSet<DIE_FIN_CORRESP> DIE_FIN_CORRESP { get; set; }

        public DbSet<DIE_FIN_CORRESP_MOV> DIE_FIN_CORRESP_MOV { get; set; }

        public DbSet<DIE_PATRIMONIO_MOV> DIE_PATRIMONIO_MOV { get; set; }

        public DbSet<DIE_CONTROLE_APR_PROD> DIE_CONTROLE_APR_PROD { get; set; }

        public DbSet<DIE_VEN_TOTAL_COMISS> DIE_VEN_TOTAL_COMISS { get; set; }

        public DbSet<DIE_FPG_EVENTO> DIE_FPG_EVENTO { get; set; }

        public DbSet<DIE_CAIXA_HIST> DIE_CAIXA_HIST { get; set; }

        public DbSet<DIE_CRC_TIT_RET_SERV> DIE_CRC_TIT_RET_SERV { get; set; }

        public DbSet<DIE_CRC_TITULO_RETORNO> DIE_CRC_TITULO_RETORNO { get; set; }

        public DbSet<DIE_FAT_MONTAGEM> DIE_FAT_MONTAGEM { get; set; }

        public DbSet<DIE_FAT_MONTAGEM_ITEM> DIE_FAT_MONTAGEM_ITEM { get; set; }

        public DbSet<DIE_FAT_NFS_ITEM_RETORNO> DIE_FAT_NFS_ITEM_RETORNO { get; set; }

        public DbSet<DIE_FAT_NFS_RET> DIE_FAT_NFS_RET { get; set; }

        public DbSet<DIE_FAT_PRE_NFS> DIE_FAT_PRE_NFS { get; set; }

        public DbSet<DIE_FAT_PRE_NFS_ITEM> DIE_FAT_PRE_NFS_ITEM { get; set; }

        public DbSet<DIE_FAT_PRE_SERVICO> DIE_FAT_PRE_SERVICO { get; set; }

        public DbSet<DIE_FAT_SERVICO_RET> DIE_FAT_SERVICO_RET { get; set; }

        public DbSet<DIE_PARAMETROS_FIL> DIE_PARAMETROS_FIL { get; set; }

        public DbSet<DIE_PRE_CRC_TITULO> DIE_PRE_CRC_TITULO { get; set; }

        public DbSet<DIE_CARTAO_CR_CONC> DIE_CARTAO_CR_CONC { get; set; }

        public DbSet<DIE_LOGO_MARCA> DIE_LOGO_MARCA { get; set; }

        public DbSet<DIE_LOGO_MARCA_IMAGEM> DIE_LOGO_MARCA_IMAGEM { get; set; }

        public DbSet<DIE_CARTAO_CR_VENDA> DIE_CARTAO_CR_VENDA { get; set; }

        public DbSet<PROD_SITE> PROD_SITE { get; set; }

        public DbSet<DIE_CRC_RENEG_OUTLJ_TMP> DIE_CRC_RENEG_OUTLJ_TMP { get; set; }

        public DbSet<DIE_CONT_TRANSP_SITE_MOV> DIE_CONT_TRANSP_SITE_MOV { get; set; }

        public DbSet<DIE_PATRIMONIO> DIE_PATRIMONIO { get; set; }

        public DbSet<DIE_CAR_VISA_CANC> DIE_CAR_VISA_CANC { get; set; }

        public DbSet<DIE_CRC_POR_CONTA> DIE_CRC_POR_CONTA { get; set; }

        public DbSet<DIE_PATRIMONIO_DESC> DIE_PATRIMONIO_DESC { get; set; }

        public DbSet<DIE_ISSQN_SUBITEM> DIE_ISSQN_SUBITEM { get; set; }

        public DbSet<DIE_ISSQN> DIE_ISSQN { get; set; }

        public DbSet<DIE_CONTROLE_TRANSP_SITE> DIE_CONTROLE_TRANSP_SITE { get; set; }

        public DbSet<NCM_DBF> NCM_DBF { get; set; }

        public DbSet<DIE_CTB_VALORES_FECH> DIE_CTB_VALORES_FECH { get; set; }

        public DbSet<DIE_CAR_REDE_ALUGUEIS> DIE_CAR_REDE_ALUGUEIS { get; set; }

        public DbSet<DIE_SOLICITACAO_CHAMADO> DIE_SOLICITACAO_CHAMADO { get; set; }

        public DbSet<DIE_CRC_TIT_TOT> DIE_CRC_TIT_TOT { get; set; }

        public DbSet<DIE_PEDIDO_TEMP> DIE_PEDIDO_TEMP { get; set; }

        public DbSet<DIE_PEDIDO_ITEM_TEMP> DIE_PEDIDO_ITEM_TEMP { get; set; }

        public DbSet<INVENTARIO_F58> INVENTARIO_F58 { get; set; }

        public DbSet<INVENTARIO_F52> INVENTARIO_F52 { get; set; }

        public DbSet<DIE_CARGA_DIARIO_FOR_2022> DIE_CARGA_DIARIO_FOR_2022 { get; set; }

        public DbSet<DIE_CTB_SERVICOS_TOMADOS> DIE_CTB_SERVICOS_TOMADOS { get; set; }

        public DbSet<DIE_EST_AUDITORIA_ALMOX> DIE_EST_AUDITORIA_ALMOX { get; set; }

        public DbSet<DIE_EST_AUDITORIA_ALMOX_ITEM> DIE_EST_AUDITORIA_ALMOX_ITEM { get; set; }

        public DbSet<CAILOJA_BKP> CAILOJA_BKP { get; set; }

        public DbSet<DIE_DATA_TMP> DIE_DATA_TMP { get; set; }

        public DbSet<DIE_LINK_SITES> DIE_LINK_SITES { get; set; }

        public DbSet<DIE_FIN_EXTRATO_DEPARA> DIE_FIN_EXTRATO_DEPARA { get; set; }

        public DbSet<DIE_CHAMADO> DIE_CHAMADO { get; set; }

        public DbSet<DIE_POSICAO_CLI_INCOBR> DIE_POSICAO_CLI_INCOBR { get; set; }

        public DbSet<DIE_FAT_RESUMO_SERV> DIE_FAT_RESUMO_SERV { get; set; }

        public DbSet<DIE_FAT_XML_SITE> DIE_FAT_XML_SITE { get; set; }

        public DbSet<DIE_FAT_XML_SITE_ITEM> DIE_FAT_XML_SITE_ITEM { get; set; }

        public DbSet<DIE_FAT_XML_SITE_PAG> DIE_FAT_XML_SITE_PAG { get; set; }

        public DbSet<DIE_COD_PAG_SITE> DIE_COD_PAG_SITE { get; set; }

        public DbSet<DIE_FAT_NOTAS_TMP> DIE_FAT_NOTAS_TMP { get; set; }

        public DbSet<BEG_NFE_ARQ_XML_SITE> BEG_NFE_ARQ_XML_SITE { get; set; }

        public DbSet<BEG_NFE_XML_SITE_TEMP> BEG_NFE_XML_SITE_TEMP { get; set; }

        public DbSet<DIE_AD_ROLE_TP_ESPEC> DIE_AD_ROLE_TP_ESPEC { get; set; }

        public DbSet<DIE_FIN_FLUXO_CAIXA> DIE_FIN_FLUXO_CAIXA { get; set; }

        public DbSet<DIE_DEPOSITO_HIST> DIE_DEPOSITO_HIST { get; set; }

        public DbSet<DIE_FIN_DEP_VINC> DIE_FIN_DEP_VINC { get; set; }

        public DbSet<REDE_JUNHO> REDE_JUNHO { get; set; }

        public DbSet<CDL> CDL { get; set; }

        public DbSet<DIE_CARGA_DIARIO_CLI_2021> DIE_CARGA_DIARIO_CLI_2021 { get; set; }

        public DbSet<DIE_CARGA_DIARIO_FOR_2021> DIE_CARGA_DIARIO_FOR_2021 { get; set; }

        public DbSet<DIE_POSICAO_CLI03072019> DIE_POSICAO_CLI03072019 { get; set; }

        public DbSet<DIE_SALDO_INV_TOTAIS> DIE_SALDO_INV_TOTAIS { get; set; }

        public DbSet<DIE_CALENDARIO_COMERCIAL> DIE_CALENDARIO_COMERCIAL { get; set; }

        public DbSet<DIE_FAT_MONTAGEM_INTERNA> DIE_FAT_MONTAGEM_INTERNA { get; set; }

        public DbSet<DIE_FAT_MONTAGEM_INTERNA_ITEM> DIE_FAT_MONTAGEM_INTERNA_ITEM { get; set; }

        public DbSet<DIE_SALDO_INV_CONTAB> DIE_SALDO_INV_CONTAB { get; set; }

        public DbSet<DIE_CLIENTE_SITE> DIE_CLIENTE_SITE { get; set; }

        public DbSet<DIE_CLIENTE_SITE_ENDERECO> DIE_CLIENTE_SITE_ENDERECO { get; set; }

        public DbSet<FORALINHA> FORALINHA { get; set; }

        public DbSet<DIE_PRD_MOTIVO_AVARIA> DIE_PRD_MOTIVO_AVARIA { get; set; }

        public DbSet<DIE_PEDIDO_PARC_TEMP> DIE_PEDIDO_PARC_TEMP { get; set; }

        public DbSet<MVA_NOVO> MVA_NOVO { get; set; }

        public DbSet<DIE_CPG_PREVISAO_TIT> DIE_CPG_PREVISAO_TIT { get; set; }

        public DbSet<DIE_IMAGENS_PRODUTOS> DIE_IMAGENS_PRODUTOS { get; set; }

        public DbSet<DIE_CONTROLE_VERSAO> DIE_CONTROLE_VERSAO { get; set; }

        public DbSet<DIE_CONTROLE_VERSAO_LJ> DIE_CONTROLE_VERSAO_LJ { get; set; }

        public DbSet<SYS_EXPORT_TABLE_14> SYS_EXPORT_TABLE_14 { get; set; }

        public DbSet<ECF_IMPRESSORAS> ECF_IMPRESSORAS { get; set; }

        public DbSet<GINF_SISTEMAS> GINF_SISTEMAS { get; set; }

        public DbSet<LOJAS> LOJAS { get; set; }

        public DbSet<OPERADORES> OPERADORES { get; set; }

        public DbSet<PAR_STATUS> PAR_STATUS { get; set; }

        public DbSet<SIS_APLICATIVO> SIS_APLICATIVO { get; set; }

        public DbSet<SIS_EMPRESA> SIS_EMPRESA { get; set; }

        public DbSet<DIE_INSTRUCOES_IMAGENS> DIE_INSTRUCOES_IMAGENS { get; set; }

        public DbSet<DIE_NFE_CONVENIO> DIE_NFE_CONVENIO { get; set; }

        public DbSet<DIE_NFE_CONV_NOTAS> DIE_NFE_CONV_NOTAS { get; set; }

        public DbSet<NCM_DESC_NOVA> NCM_DESC_NOVA { get; set; }

        public DbSet<DIE_CARGA_DIARIO_CLI_2022> DIE_CARGA_DIARIO_CLI_2022 { get; set; }

        public DbSet<DIE_CARTAO_PARCELA_LOTE> DIE_CARTAO_PARCELA_LOTE { get; set; }

        public DbSet<DIE_USER_TP_PEDIDO> DIE_USER_TP_PEDIDO { get; set; }

        public DbSet<DIE_CPR_NFS_VINC_CTE> DIE_CPR_NFS_VINC_CTE { get; set; }

        public DbSet<DIE_MOV_USOCONSUMO_TMP> DIE_MOV_USOCONSUMO_TMP { get; set; }

        public DbSet<DIE_CRC_CLI_INATIVO_VM> DIE_CRC_CLI_INATIVO_VM { get; set; }

        public DbSet<DIE_PRD_PROMOCAO_AUTO> DIE_PRD_PROMOCAO_AUTO { get; set; }

        public DbSet<BEG_COB_CARTORIO_BKP> BEG_COB_CARTORIO_BKP { get; set; }

        public DbSet<DIE_GAR_TEMP> DIE_GAR_TEMP { get; set; }

        public DbSet<DIE_GAR_ITEMS_TEMP> DIE_GAR_ITEMS_TEMP { get; set; }

        public DbSet<MARCO> MARCO { get; set; }

        public DbSet<DIE_VEN_NAO_REALIZADA> DIE_VEN_NAO_REALIZADA { get; set; }

        public DbSet<DIE_VEN_MOTIVO_NAO> DIE_VEN_MOTIVO_NAO { get; set; }

        public DbSet<DIE_FIN_SOL_FECH_CAIXA> DIE_FIN_SOL_FECH_CAIXA { get; set; }

        public DbSet<DIE_TIT_GERAL_TMP> DIE_TIT_GERAL_TMP { get; set; }

        public DbSet<DIE_FIN_FLU_CONTA> DIE_FIN_FLU_CONTA { get; set; }

        public DbSet<DIE_FIN_FLU_CONTA_CONTAB> DIE_FIN_FLU_CONTA_CONTAB { get; set; }

        public DbSet<DIE_CARTAO_SALDOS_CONTAB> DIE_CARTAO_SALDOS_CONTAB { get; set; }

        public DbSet<DIE_CPG_APROVA_TIT_LOTE> DIE_CPG_APROVA_TIT_LOTE { get; set; }

        public DbSet<DIE_CPG_APROVA_TITULOS> DIE_CPG_APROVA_TITULOS { get; set; }

        public DbSet<PAGAR_DBF> PAGAR_DBF { get; set; }

        public DbSet<SYS_EXPORT_TABLE_12> SYS_EXPORT_TABLE_12 { get; set; }

        public DbSet<SYS_EXPORT_TABLE_13> SYS_EXPORT_TABLE_13 { get; set; }

        public DbSet<A_ASSET> A_ASSET { get; set; }

        public DbSet<A_ASSET_GROUP> A_ASSET_GROUP { get; set; }

        public DbSet<AD_ALERT> AD_ALERT { get; set; }

        public DbSet<AD_ALERTPROCESSOR> AD_ALERTPROCESSOR { get; set; }

        public DbSet<AD_ALERTPROCESSORLOG> AD_ALERTPROCESSORLOG { get; set; }

        public DbSet<AD_ALERTRECIPIENT> AD_ALERTRECIPIENT { get; set; }

        public DbSet<AD_ALERTRULE> AD_ALERTRULE { get; set; }

        public DbSet<AD_ARCHIVE> AD_ARCHIVE { get; set; }

        public DbSet<AD_ATTACHMENT> AD_ATTACHMENT { get; set; }

        public DbSet<AD_CHANGELOG> AD_CHANGELOG { get; set; }

        public DbSet<AD_CLIENT> AD_CLIENT { get; set; }

        public DbSet<AD_CLIENTINFO> AD_CLIENTINFO { get; set; }

        public DbSet<AD_COLUMN> AD_COLUMN { get; set; }

        public DbSet<AD_COLUMN_TRL> AD_COLUMN_TRL { get; set; }

        public DbSet<AD_DESKTOP> AD_DESKTOP { get; set; }

        public DbSet<AD_DESKTOP_TRL> AD_DESKTOP_TRL { get; set; }

        public DbSet<AD_DESKTOPWORKBENCH> AD_DESKTOPWORKBENCH { get; set; }

        public DbSet<AD_ELEMENT> AD_ELEMENT { get; set; }

        public DbSet<AD_ELEMENT_TRL> AD_ELEMENT_TRL { get; set; }

        public DbSet<AD_FIELD> AD_FIELD { get; set; }

        public DbSet<AD_FIELDGROUP> AD_FIELDGROUP { get; set; }

        public DbSet<AD_FIELDGROUP_TRL> AD_FIELDGROUP_TRL { get; set; }

        public DbSet<AD_FIELD_TRL> AD_FIELD_TRL { get; set; }

        public DbSet<AD_FORM> AD_FORM { get; set; }

        public DbSet<AD_FORM_ACCESS> AD_FORM_ACCESS { get; set; }

        public DbSet<AD_FORM_TRL> AD_FORM_TRL { get; set; }

        public DbSet<AD_IMAGE> AD_IMAGE { get; set; }

        public DbSet<AD_IMPFORMAT> AD_IMPFORMAT { get; set; }

        public DbSet<AD_IMPFORMAT_ROW> AD_IMPFORMAT_ROW { get; set; }

        public DbSet<AD_LANGUAGE> AD_LANGUAGE { get; set; }

        public DbSet<AD_MENU> AD_MENU { get; set; }

        public DbSet<AD_MENU_TRL> AD_MENU_TRL { get; set; }

        public DbSet<AD_MESSAGE> AD_MESSAGE { get; set; }

        public DbSet<AD_MESSAGE_TRL> AD_MESSAGE_TRL { get; set; }

        public DbSet<AD_ORG> AD_ORG { get; set; }

        public DbSet<AD_ORGINFO> AD_ORGINFO { get; set; }

        public DbSet<AD_ORGTYPE> AD_ORGTYPE { get; set; }

        public DbSet<AD_PINSTANCE> AD_PINSTANCE { get; set; }

        public DbSet<AD_PINSTANCE_PARA> AD_PINSTANCE_PARA { get; set; }

        public DbSet<AD_PREFERENCE> AD_PREFERENCE { get; set; }

        public DbSet<AD_PRINTCOLOR> AD_PRINTCOLOR { get; set; }

        public DbSet<AD_PRINTFONT> AD_PRINTFONT { get; set; }

        public DbSet<AD_PRINTFORM> AD_PRINTFORM { get; set; }

        public DbSet<AD_PRINTFORMAT> AD_PRINTFORMAT { get; set; }

        public DbSet<AD_PRINTFORMATITEM> AD_PRINTFORMATITEM { get; set; }

        public DbSet<AD_PRINTFORMATITEM_TRL> AD_PRINTFORMATITEM_TRL { get; set; }

        public DbSet<AD_PRINTPAPER> AD_PRINTPAPER { get; set; }

        public DbSet<AD_PRINTTABLEFORMAT> AD_PRINTTABLEFORMAT { get; set; }

        public DbSet<AD_PRIVATE_ACCESS> AD_PRIVATE_ACCESS { get; set; }

        public DbSet<AD_PROCESS> AD_PROCESS { get; set; }

        public DbSet<AD_PROCESS_ACCESS> AD_PROCESS_ACCESS { get; set; }

        public DbSet<AD_PROCESS_PARA> AD_PROCESS_PARA { get; set; }

        public DbSet<AD_PROCESS_PARA_TRL> AD_PROCESS_PARA_TRL { get; set; }

        public DbSet<AD_PROCESS_TRL> AD_PROCESS_TRL { get; set; }

        public DbSet<AD_REFERENCE> AD_REFERENCE { get; set; }

        public DbSet<AD_REFERENCE_TRL> AD_REFERENCE_TRL { get; set; }

        public DbSet<AD_REF_LIST> AD_REF_LIST { get; set; }

        public DbSet<AD_REF_LIST_TRL> AD_REF_LIST_TRL { get; set; }

        public DbSet<AD_REF_TABLE> AD_REF_TABLE { get; set; }

        public DbSet<AD_REPLICATION> AD_REPLICATION { get; set; }

        public DbSet<AD_REPLICATIONSTRATEGY> AD_REPLICATIONSTRATEGY { get; set; }

        public DbSet<AD_REPLICATIONTABLE> AD_REPLICATIONTABLE { get; set; }

        public DbSet<AD_REPORTVIEW> AD_REPORTVIEW { get; set; }

        public DbSet<AD_ROLE> AD_ROLE { get; set; }

        public DbSet<AD_ROLE_ORGACCESS> AD_ROLE_ORGACCESS { get; set; }

        public DbSet<AD_SCHEDULER> AD_SCHEDULER { get; set; }

        public DbSet<AD_SCHEDULERLOG> AD_SCHEDULERLOG { get; set; }

        public DbSet<AD_SCHEDULER_PARA> AD_SCHEDULER_PARA { get; set; }

        public DbSet<AD_SEQUENCE> AD_SEQUENCE { get; set; }

        public DbSet<AD_SESSION> AD_SESSION { get; set; }

        public DbSet<AD_SYSTEM> AD_SYSTEM { get; set; }

        public DbSet<AD_TAB> AD_TAB { get; set; }

        public DbSet<AD_TABLE> AD_TABLE { get; set; }

        public DbSet<AD_TABLE_ACCESS> AD_TABLE_ACCESS { get; set; }

        public DbSet<AD_TABLE_TRL> AD_TABLE_TRL { get; set; }

        public DbSet<AD_TAB_TRL> AD_TAB_TRL { get; set; }

        public DbSet<AD_TASK> AD_TASK { get; set; }

        public DbSet<AD_TASK_ACCESS> AD_TASK_ACCESS { get; set; }

        public DbSet<AD_TASK_TRL> AD_TASK_TRL { get; set; }

        public DbSet<AD_TREE> AD_TREE { get; set; }

        public DbSet<AD_TREEBAR> AD_TREEBAR { get; set; }

        public DbSet<AD_TREENODE> AD_TREENODE { get; set; }

        public DbSet<AD_TREENODEBP> AD_TREENODEBP { get; set; }

        public DbSet<AD_TREENODEMM> AD_TREENODEMM { get; set; }

        public DbSet<AD_TREENODEPR> AD_TREENODEPR { get; set; }

        public DbSet<AD_USER> AD_USER { get; set; }

        public DbSet<AD_USERMAIL> AD_USERMAIL { get; set; }

        public DbSet<AD_USER_ORGACCESS> AD_USER_ORGACCESS { get; set; }

        public DbSet<AD_USER_ROLES> AD_USER_ROLES { get; set; }

        public DbSet<AD_VAL_RULE> AD_VAL_RULE { get; set; }

        public DbSet<AD_WF_ACTIVITY> AD_WF_ACTIVITY { get; set; }

        public DbSet<AD_WF_EVENTAUDIT> AD_WF_EVENTAUDIT { get; set; }

        public DbSet<AD_WF_NEXTCONDITION> AD_WF_NEXTCONDITION { get; set; }

        public DbSet<AD_WF_NODE> AD_WF_NODE { get; set; }

        public DbSet<AD_WF_NODENEXT> AD_WF_NODENEXT { get; set; }

        public DbSet<AD_WF_NODE_PARA> AD_WF_NODE_PARA { get; set; }

        public DbSet<AD_WF_NODE_TRL> AD_WF_NODE_TRL { get; set; }

        public DbSet<AD_WF_PROCESS> AD_WF_PROCESS { get; set; }

        public DbSet<AD_WF_RESPONSIBLE> AD_WF_RESPONSIBLE { get; set; }

        public DbSet<AD_WINDOW> AD_WINDOW { get; set; }

        public DbSet<AD_WINDOW_ACCESS> AD_WINDOW_ACCESS { get; set; }

        public DbSet<AD_WINDOW_TRL> AD_WINDOW_TRL { get; set; }

        public DbSet<AD_WORKBENCH> AD_WORKBENCH { get; set; }

        public DbSet<AD_WORKBENCH_TRL> AD_WORKBENCH_TRL { get; set; }

        public DbSet<AD_WORKBENCHWINDOW> AD_WORKBENCHWINDOW { get; set; }

        public DbSet<AD_WORKFLOW> AD_WORKFLOW { get; set; }

        public DbSet<AD_WORKFLOW_ACCESS> AD_WORKFLOW_ACCESS { get; set; }

        public DbSet<AD_WORKFLOWPROCESSOR> AD_WORKFLOWPROCESSOR { get; set; }

        public DbSet<AD_WORKFLOWPROCESSORLOG> AD_WORKFLOWPROCESSORLOG { get; set; }

        public DbSet<AD_WORKFLOW_TRL> AD_WORKFLOW_TRL { get; set; }

        public DbSet<C_ACCTPROCESSOR> C_ACCTPROCESSOR { get; set; }

        public DbSet<C_ACCTPROCESSORLOG> C_ACCTPROCESSORLOG { get; set; }

        public DbSet<C_ACCTSCHEMA> C_ACCTSCHEMA { get; set; }

        public DbSet<C_ACCTSCHEMA_DEFAULT> C_ACCTSCHEMA_DEFAULT { get; set; }

        public DbSet<C_ACCTSCHEMA_ELEMENT> C_ACCTSCHEMA_ELEMENT { get; set; }

        public DbSet<C_ACCTSCHEMA_GL> C_ACCTSCHEMA_GL { get; set; }

        public DbSet<C_ALLOCATIONHDR> C_ALLOCATIONHDR { get; set; }

        public DbSet<C_ALLOCATIONLINE> C_ALLOCATIONLINE { get; set; }

        public DbSet<C_BANK> C_BANK { get; set; }

        public DbSet<C_BANKACCOUNT> C_BANKACCOUNT { get; set; }

        public DbSet<C_BANKACCOUNT_ACCT> C_BANKACCOUNT_ACCT { get; set; }

        public DbSet<C_BANKACCOUNTDOC> C_BANKACCOUNTDOC { get; set; }

        public DbSet<C_BANKSTATEMENT> C_BANKSTATEMENT { get; set; }

        public DbSet<C_BANKSTATEMENTLINE> C_BANKSTATEMENTLINE { get; set; }

        public DbSet<C_BPARTNER> C_BPARTNER { get; set; }

        public DbSet<C_BPARTNER_LOCATION> C_BPARTNER_LOCATION { get; set; }

        public DbSet<C_BPARTNER_PRODUCT> C_BPARTNER_PRODUCT { get; set; }

        public DbSet<C_BP_BANKACCOUNT> C_BP_BANKACCOUNT { get; set; }

        public DbSet<C_BP_CUSTOMER_ACCT> C_BP_CUSTOMER_ACCT { get; set; }

        public DbSet<C_BP_EMPLOYEE_ACCT> C_BP_EMPLOYEE_ACCT { get; set; }

        public DbSet<C_BP_GROUP> C_BP_GROUP { get; set; }

        public DbSet<C_BP_GROUP_ACCT> C_BP_GROUP_ACCT { get; set; }

        public DbSet<C_BP_RELATION> C_BP_RELATION { get; set; }

        public DbSet<C_BP_VENDOR_ACCT> C_BP_VENDOR_ACCT { get; set; }

        public DbSet<C_CALENDAR> C_CALENDAR { get; set; }

        public DbSet<C_CAMPAIGN> C_CAMPAIGN { get; set; }

        public DbSet<C_CASH> C_CASH { get; set; }

        public DbSet<C_CASHBOOK> C_CASHBOOK { get; set; }

        public DbSet<C_CASHBOOK_ACCT> C_CASHBOOK_ACCT { get; set; }

        public DbSet<C_CASHLINE> C_CASHLINE { get; set; }

        public DbSet<C_CHANNEL> C_CHANNEL { get; set; }

        public DbSet<C_CHARGE> C_CHARGE { get; set; }

        public DbSet<C_CHARGE_ACCT> C_CHARGE_ACCT { get; set; }

        public DbSet<C_CITY> C_CITY { get; set; }

        public DbSet<C_COMMISSION> C_COMMISSION { get; set; }

        public DbSet<C_COMMISSIONLINE> C_COMMISSIONLINE { get; set; }

        public DbSet<C_CONVERSION_RATE> C_CONVERSION_RATE { get; set; }

        public DbSet<C_CONVERSIONTYPE> C_CONVERSIONTYPE { get; set; }

        public DbSet<C_COUNTRY> C_COUNTRY { get; set; }

        public DbSet<C_COUNTRY_TRL> C_COUNTRY_TRL { get; set; }

        public DbSet<C_CURRENCY> C_CURRENCY { get; set; }

        public DbSet<C_CURRENCY_TRL> C_CURRENCY_TRL { get; set; }

        public DbSet<C_CYCLE> C_CYCLE { get; set; }

        public DbSet<C_CYCLEPHASE> C_CYCLEPHASE { get; set; }

        public DbSet<C_CYCLESTEP> C_CYCLESTEP { get; set; }

        public DbSet<C_DOCTYPE> C_DOCTYPE { get; set; }

        public DbSet<C_DOCTYPECOUNTER> C_DOCTYPECOUNTER { get; set; }

        public DbSet<C_DOCTYPE_TRL> C_DOCTYPE_TRL { get; set; }

        public DbSet<C_DUNNING> C_DUNNING { get; set; }

        public DbSet<C_DUNNINGLEVEL> C_DUNNINGLEVEL { get; set; }

        public DbSet<C_DUNNINGLEVEL_TRL> C_DUNNINGLEVEL_TRL { get; set; }

        public DbSet<C_ELEMENT> C_ELEMENT { get; set; }

        public DbSet<C_ELEMENTVALUE> C_ELEMENTVALUE { get; set; }

        public DbSet<C_ELEMENTVALUE_TRL> C_ELEMENTVALUE_TRL { get; set; }

        public DbSet<C_GREETING> C_GREETING { get; set; }

        public DbSet<C_GREETING_TRL> C_GREETING_TRL { get; set; }

        public DbSet<C_INVOICE> C_INVOICE { get; set; }

        public DbSet<C_INVOICEPAYSCHEDULE> C_INVOICEPAYSCHEDULE { get; set; }

        public DbSet<C_INVOICESCHEDULE> C_INVOICESCHEDULE { get; set; }

        public DbSet<C_INVOICETAX> C_INVOICETAX { get; set; }

        public DbSet<C_JOB> C_JOB { get; set; }

        public DbSet<C_JOBCATEGORY> C_JOBCATEGORY { get; set; }

        public DbSet<C_LOCATION> C_LOCATION { get; set; }

        public DbSet<C_NONBUSINESSDAY> C_NONBUSINESSDAY { get; set; }

        public DbSet<C_ORDER> C_ORDER { get; set; }

        public DbSet<C_ORDERLINE> C_ORDERLINE { get; set; }

        public DbSet<C_ORDERTAX> C_ORDERTAX { get; set; }

        public DbSet<C_ORGASSIGNMENT> C_ORGASSIGNMENT { get; set; }

        public DbSet<C_PAYMENT> C_PAYMENT { get; set; }

        public DbSet<C_PAYMENTPROCESSOR> C_PAYMENTPROCESSOR { get; set; }

        public DbSet<C_PAYMENTTERM> C_PAYMENTTERM { get; set; }

        public DbSet<C_PAYMENTTERM_TRL> C_PAYMENTTERM_TRL { get; set; }

        public DbSet<C_PAYSCHEDULE> C_PAYSCHEDULE { get; set; }

        public DbSet<C_PAYSELECTION> C_PAYSELECTION { get; set; }

        public DbSet<C_PAYSELECTIONCHECK> C_PAYSELECTIONCHECK { get; set; }

        public DbSet<C_PAYSELECTIONLINE> C_PAYSELECTIONLINE { get; set; }

        public DbSet<C_PERIOD> C_PERIOD { get; set; }

        public DbSet<C_PERIODCONTROL> C_PERIODCONTROL { get; set; }

        public DbSet<C_PHASE> C_PHASE { get; set; }

        public DbSet<C_POS> C_POS { get; set; }

        public DbSet<C_POSKEY> C_POSKEY { get; set; }

        public DbSet<C_POSKEYLAYOUT> C_POSKEYLAYOUT { get; set; }

        public DbSet<C_PROJECT> C_PROJECT { get; set; }

        public DbSet<C_PROJECT_ACCT> C_PROJECT_ACCT { get; set; }

        public DbSet<C_PROJECTLINE> C_PROJECTLINE { get; set; }

        public DbSet<C_PROJECTTYPE> C_PROJECTTYPE { get; set; }

        public DbSet<CREATE$JAVA$LOB$TABLE> CREATEJAVALOBTABLE { get; set; }

        public DbSet<C_RECURRING> C_RECURRING { get; set; }

        public DbSet<C_REGION> C_REGION { get; set; }

        public DbSet<C_REVENUERECOGNITION> C_REVENUERECOGNITION { get; set; }

        public DbSet<C_RFQ> C_RFQ { get; set; }

        public DbSet<C_RFQLINE> C_RFQLINE { get; set; }

        public DbSet<C_RFQLINEQTY> C_RFQLINEQTY { get; set; }

        public DbSet<C_RFQ_TOPIC> C_RFQ_TOPIC { get; set; }

        public DbSet<C_RFQ_TOPICSUBSCRIBER> C_RFQ_TOPICSUBSCRIBER { get; set; }

        public DbSet<C_SALESREGION> C_SALESREGION { get; set; }

        public DbSet<C_TASK> C_TASK { get; set; }

        public DbSet<C_TAX> C_TAX { get; set; }

        public DbSet<C_TAX_ACCT> C_TAX_ACCT { get; set; }

        public DbSet<C_TAXCATEGORY> C_TAXCATEGORY { get; set; }

        public DbSet<C_TAXCATEGORY_TRL> C_TAXCATEGORY_TRL { get; set; }

        public DbSet<C_TAX_TRL> C_TAX_TRL { get; set; }

        public DbSet<C_UOM> C_UOM { get; set; }

        public DbSet<C_UOM_CONVERSION> C_UOM_CONVERSION { get; set; }

        public DbSet<C_UOM_TRL> C_UOM_TRL { get; set; }

        public DbSet<C_VALIDCOMBINATION> C_VALIDCOMBINATION { get; set; }

        public DbSet<C_YEAR> C_YEAR { get; set; }

        public DbSet<FACT_ACCT> FACT_ACCT { get; set; }

        public DbSet<GL_BUDGET> GL_BUDGET { get; set; }

        public DbSet<GL_CATEGORY> GL_CATEGORY { get; set; }

        public DbSet<GL_DISTRIBUTION> GL_DISTRIBUTION { get; set; }

        public DbSet<GL_DISTRIBUTIONLINE> GL_DISTRIBUTIONLINE { get; set; }

        public DbSet<GL_JOURNAL> GL_JOURNAL { get; set; }

        public DbSet<GL_JOURNALBATCH> GL_JOURNALBATCH { get; set; }

        public DbSet<I_CONVERSION_RATE> I_CONVERSION_RATE { get; set; }

        public DbSet<JAVA$CLASS$MD5$TABLE> JAVACLASSMD5TABLE { get; set; }

        public DbSet<K_CATEGORY> K_CATEGORY { get; set; }

        public DbSet<K_SOURCE> K_SOURCE { get; set; }

        public DbSet<K_TOPIC> K_TOPIC { get; set; }

        public DbSet<K_TYPE> K_TYPE { get; set; }

        public DbSet<M_ATTRIBUTE> M_ATTRIBUTE { get; set; }

        public DbSet<M_ATTRIBUTEINSTANCE> M_ATTRIBUTEINSTANCE { get; set; }

        public DbSet<M_ATTRIBUTESEARCH> M_ATTRIBUTESEARCH { get; set; }

        public DbSet<M_ATTRIBUTESET> M_ATTRIBUTESET { get; set; }

        public DbSet<M_ATTRIBUTESETINSTANCE> M_ATTRIBUTESETINSTANCE { get; set; }

        public DbSet<M_ATTRIBUTEUSE> M_ATTRIBUTEUSE { get; set; }

        public DbSet<M_ATTRIBUTEVALUE> M_ATTRIBUTEVALUE { get; set; }

        public DbSet<M_BOM> M_BOM { get; set; }

        public DbSet<M_BOMALTERNATIVE> M_BOMALTERNATIVE { get; set; }

        public DbSet<M_CHANGENOTICE> M_CHANGENOTICE { get; set; }

        public DbSet<M_COST> M_COST { get; set; }

        public DbSet<M_COSTELEMENT> M_COSTELEMENT { get; set; }

        public DbSet<M_COSTQUEUE> M_COSTQUEUE { get; set; }

        public DbSet<M_COSTTYPE> M_COSTTYPE { get; set; }

        public DbSet<M_DISCOUNTSCHEMA> M_DISCOUNTSCHEMA { get; set; }

        public DbSet<M_DISCOUNTSCHEMABREAK> M_DISCOUNTSCHEMABREAK { get; set; }

        public DbSet<M_DISCOUNTSCHEMALINE> M_DISCOUNTSCHEMALINE { get; set; }

        public DbSet<M_DISTRIBUTIONLIST> M_DISTRIBUTIONLIST { get; set; }

        public DbSet<M_DISTRIBUTIONLISTLINE> M_DISTRIBUTIONLISTLINE { get; set; }

        public DbSet<M_DISTRIBUTIONRUN> M_DISTRIBUTIONRUN { get; set; }

        public DbSet<M_DISTRIBUTIONRUNLINE> M_DISTRIBUTIONRUNLINE { get; set; }

        public DbSet<M_FREIGHT> M_FREIGHT { get; set; }

        public DbSet<M_FREIGHTCATEGORY> M_FREIGHTCATEGORY { get; set; }

        public DbSet<M_INOUT> M_INOUT { get; set; }

        public DbSet<M_INOUTCONFIRM> M_INOUTCONFIRM { get; set; }

        public DbSet<M_INOUTLINE> M_INOUTLINE { get; set; }

        public DbSet<M_INOUTLINECONFIRM> M_INOUTLINECONFIRM { get; set; }

        public DbSet<M_INVENTORY> M_INVENTORY { get; set; }

        public DbSet<M_INVENTORYLINE> M_INVENTORYLINE { get; set; }

        public DbSet<M_LOCATOR> M_LOCATOR { get; set; }

        public DbSet<M_LOTCTL> M_LOTCTL { get; set; }

        public DbSet<M_PRICELIST> M_PRICELIST { get; set; }

        public DbSet<M_PRICELIST_VERSION> M_PRICELIST_VERSION { get; set; }

        public DbSet<M_PRODUCT> M_PRODUCT { get; set; }

        public DbSet<M_PRODUCT_ACCT> M_PRODUCT_ACCT { get; set; }

        public DbSet<M_PRODUCT_BOM> M_PRODUCT_BOM { get; set; }

        public DbSet<M_PRODUCT_CATEGORY> M_PRODUCT_CATEGORY { get; set; }

        public DbSet<M_PRODUCT_CATEGORY_ACCT> M_PRODUCT_CATEGORY_ACCT { get; set; }

        public DbSet<M_PRODUCT_COSTING> M_PRODUCT_COSTING { get; set; }

        public DbSet<M_PRODUCTDOWNLOAD> M_PRODUCTDOWNLOAD { get; set; }

        public DbSet<M_PRODUCT_PO> M_PRODUCT_PO { get; set; }

        public DbSet<M_PRODUCTPRICE> M_PRODUCTPRICE { get; set; }

        public DbSet<M_PRODUCT_TRL> M_PRODUCT_TRL { get; set; }

        public DbSet<M_RELATEDPRODUCT> M_RELATEDPRODUCT { get; set; }

        public DbSet<M_REPLENISH> M_REPLENISH { get; set; }

        public DbSet<M_REQUISITION> M_REQUISITION { get; set; }

        public DbSet<M_REQUISITIONLINE> M_REQUISITIONLINE { get; set; }

        public DbSet<M_RMA> M_RMA { get; set; }

        public DbSet<M_RMATYPE> M_RMATYPE { get; set; }

        public DbSet<M_SERNOCTL> M_SERNOCTL { get; set; }

        public DbSet<M_SHIPPER> M_SHIPPER { get; set; }

        public DbSet<M_STORAGE> M_STORAGE { get; set; }

        public DbSet<M_WAREHOUSE> M_WAREHOUSE { get; set; }

        public DbSet<M_WAREHOUSE_ACCT> M_WAREHOUSE_ACCT { get; set; }

        public DbSet<PA_COLOR> PA_COLOR { get; set; }

        public DbSet<PA_MEASURECALC> PA_MEASURECALC { get; set; }

        public DbSet<PA_REPORT> PA_REPORT { get; set; }

        public DbSet<PA_REPORTCOLUMN> PA_REPORTCOLUMN { get; set; }

        public DbSet<PA_REPORTCOLUMNSET> PA_REPORTCOLUMNSET { get; set; }

        public DbSet<PA_REPORTLINE> PA_REPORTLINE { get; set; }

        public DbSet<PA_REPORTLINESET> PA_REPORTLINESET { get; set; }

        public DbSet<PA_REPORTSOURCE> PA_REPORTSOURCE { get; set; }

        public DbSet<PA_SLA_CRITERIA> PA_SLA_CRITERIA { get; set; }

        public DbSet<PA_SLA_GOAL> PA_SLA_GOAL { get; set; }

        public DbSet<PA_SLA_MEASURE> PA_SLA_MEASURE { get; set; }

        public DbSet<R_CATEGORY> R_CATEGORY { get; set; }

        public DbSet<R_CATEGORYUPDATES> R_CATEGORYUPDATES { get; set; }

        public DbSet<R_CONTACTINTEREST> R_CONTACTINTEREST { get; set; }

        public DbSet<R_GROUP> R_GROUP { get; set; }

        public DbSet<R_GROUPUPDATES> R_GROUPUPDATES { get; set; }

        public DbSet<R_INTERESTAREA> R_INTERESTAREA { get; set; }

        public DbSet<R_MAILTEXT> R_MAILTEXT { get; set; }

        public DbSet<R_REQUEST> R_REQUEST { get; set; }

        public DbSet<R_REQUESTACTION> R_REQUESTACTION { get; set; }

        public DbSet<R_REQUESTPROCESSOR> R_REQUESTPROCESSOR { get; set; }

        public DbSet<R_REQUESTPROCESSORLOG> R_REQUESTPROCESSORLOG { get; set; }

        public DbSet<R_REQUESTPROCESSOR_ROUTE> R_REQUESTPROCESSOR_ROUTE { get; set; }

        public DbSet<R_REQUESTTYPE> R_REQUESTTYPE { get; set; }

        public DbSet<R_REQUESTTYPEUPDATES> R_REQUESTTYPEUPDATES { get; set; }

        public DbSet<R_REQUESTUPDATE> R_REQUESTUPDATE { get; set; }

        public DbSet<R_RESOLUTION> R_RESOLUTION { get; set; }

        public DbSet<R_STANDARDRESPONSE> R_STANDARDRESPONSE { get; set; }

        public DbSet<R_STATUS> R_STATUS { get; set; }

        public DbSet<S_EXPENSETYPE> S_EXPENSETYPE { get; set; }

        public DbSet<S_RESOURCE> S_RESOURCE { get; set; }

        public DbSet<S_RESOURCEASSIGNMENT> S_RESOURCEASSIGNMENT { get; set; }

        public DbSet<S_RESOURCETYPE> S_RESOURCETYPE { get; set; }

        public DbSet<S_RESOURCEUNAVAILABLE> S_RESOURCEUNAVAILABLE { get; set; }

        public DbSet<S_TIMEEXPENSE> S_TIMEEXPENSE { get; set; }

        public DbSet<S_TIMEEXPENSELINE> S_TIMEEXPENSELINE { get; set; }

        public DbSet<S_TRAINING> S_TRAINING { get; set; }

        public DbSet<T_REPORTSTATEMENT> T_REPORTSTATEMENT { get; set; }

        public DbSet<T_TRIALBALANCE> T_TRIALBALANCE { get; set; }

        public DbSet<W_ADVERTISEMENT> W_ADVERTISEMENT { get; set; }

        public DbSet<W_CLICKCOUNT> W_CLICKCOUNT { get; set; }

        public DbSet<W_COUNTERCOUNT> W_COUNTERCOUNT { get; set; }

        public DbSet<W_STORE> W_STORE { get; set; }

        public DbSet<W_STORE_TRL> W_STORE_TRL { get; set; }

        public DbSet<BEG_APEX_APPLICATION_ACCESS> BEG_APEX_APPLICATION_ACCESS { get; set; }

        public DbSet<BEG_CPR_COMP_FRETE> BEG_CPR_COMP_FRETE { get; set; }

        public DbSet<BEG_CPR_PRE_NFE> BEG_CPR_PRE_NFE { get; set; }

        public DbSet<BEG_CPG_PRE_TITULO> BEG_CPG_PRE_TITULO { get; set; }

        public DbSet<BEG_CPR_PRE_NFE_ITEM> BEG_CPR_PRE_NFE_ITEM { get; set; }

        public DbSet<DIE_CPR_GER_NFE> DIE_CPR_GER_NFE { get; set; }

        public DbSet<DIE_CPR_GER_NFE_ITEM> DIE_CPR_GER_NFE_ITEM { get; set; }

        public DbSet<DIE_CPR_PRE_NFE> DIE_CPR_PRE_NFE { get; set; }

        public DbSet<DIE_CPR_PRE_NFE_ITEM> DIE_CPR_PRE_NFE_ITEM { get; set; }

        public DbSet<BEG_AD_RELATORIO_CA> BEG_AD_RELATORIO_CA { get; set; }

        public DbSet<BEG_COB_TITULO_TMP> BEG_COB_TITULO_TMP { get; set; }

        public DbSet<BEG_EST_EXTRATO_TMP> BEG_EST_EXTRATO_TMP { get; set; }

        public DbSet<DIE_EST_INVENTARIO> DIE_EST_INVENTARIO { get; set; }

        public DbSet<DIE_EST_INVENTARIO_TMP> DIE_EST_INVENTARIO_TMP { get; set; }

        public DbSet<DIE_CAR_CONCILIACAO> DIE_CAR_CONCILIACAO { get; set; }

        public DbSet<DIE_INTERVALO_SORTE> DIE_INTERVALO_SORTE { get; set; }

        public DbSet<BEG_AD_FK_NOT_TABLE> BEG_AD_FK_NOT_TABLE { get; set; }

        public DbSet<BEG_AD_FK_REFERENCIA> BEG_AD_FK_REFERENCIA { get; set; }

        public DbSet<BEG_AD_IDX> BEG_AD_IDX { get; set; }

        public DbSet<BEG_AD_PRINTER> BEG_AD_PRINTER { get; set; }

        public DbSet<BEG_AD_PRINTER_COMMAND> BEG_AD_PRINTER_COMMAND { get; set; }

        public DbSet<BEG_AD_PRINTER_MODEL> BEG_AD_PRINTER_MODEL { get; set; }

        public DbSet<BEG_AGENCIA> BEG_AGENCIA { get; set; }

        public DbSet<BEG_BAIRRO> BEG_BAIRRO { get; set; }

        public DbSet<BEG_BANCO> BEG_BANCO { get; set; }

        public DbSet<BEG_CBO> BEG_CBO { get; set; }

        public DbSet<BEG_CEP> BEG_CEP { get; set; }

        public DbSet<BEG_CFOP> BEG_CFOP { get; set; }

        public DbSet<BEG_CFOP_ENT_SAI> BEG_CFOP_ENT_SAI { get; set; }

        public DbSet<BEG_CHQ_ALIQUOTA> BEG_CHQ_ALIQUOTA { get; set; }

        public DbSet<BEG_CHQ_DESTINO_REMESSA> BEG_CHQ_DESTINO_REMESSA { get; set; }

        public DbSet<BEG_CIDADE> BEG_CIDADE { get; set; }

        public DbSet<BEG_COB_AVISO> BEG_COB_AVISO { get; set; }

        public DbSet<BEG_COB_LOTE_COBR_TIT> BEG_COB_LOTE_COBR_TIT { get; set; }

        public DbSet<BEG_COBRADOR> BEG_COBRADOR { get; set; }

        public DbSet<BEG_COBRADOR_FILIAL> BEG_COBRADOR_FILIAL { get; set; }

        public DbSet<BEG_CONDICAO_PAGAMENTO> BEG_CONDICAO_PAGAMENTO { get; set; }

        public DbSet<BEG_CPG_AUTORIZACAO_PGTO> BEG_CPG_AUTORIZACAO_PGTO { get; set; }

        public DbSet<BEG_CPG_CONTA> BEG_CPG_CONTA { get; set; }

        public DbSet<BEG_CPG_HISTORICO> BEG_CPG_HISTORICO { get; set; }

        public DbSet<BEG_CPG_TIPO_RENEG> BEG_CPG_TIPO_RENEG { get; set; }

        public DbSet<BEG_CPG_TIPO_TITULO> BEG_CPG_TIPO_TITULO { get; set; }

        public DbSet<BEG_CPG_TITULO> BEG_CPG_TITULO { get; set; }

        public DbSet<BEG_CPG_TPMOV> BEG_CPG_TPMOV { get; set; }

        public DbSet<BEG_CPR_COMPRADOR> BEG_CPR_COMPRADOR { get; set; }

        public DbSet<BEG_CPR_NFE> BEG_CPR_NFE { get; set; }

        public DbSet<BEG_CPR_NFE_ITEM> BEG_CPR_NFE_ITEM { get; set; }

        public DbSet<BEG_CPR_ORDEM> BEG_CPR_ORDEM { get; set; }

        public DbSet<BEG_CPR_ORDEM_ITEM> BEG_CPR_ORDEM_ITEM { get; set; }

        public DbSet<BEG_CPR_TIPO_ORDEM> BEG_CPR_TIPO_ORDEM { get; set; }

        public DbSet<BEG_CRC_HISTORICO> BEG_CRC_HISTORICO { get; set; }

        public DbSet<BEG_CRC_LOCALIZACAO> BEG_CRC_LOCALIZACAO { get; set; }

        public DbSet<BEG_CRC_NF_DEBITO> BEG_CRC_NF_DEBITO { get; set; }

        public DbSet<BEG_CRC_NF_DEBITO_PARCELA> BEG_CRC_NF_DEBITO_PARCELA { get; set; }

        public DbSet<BEG_CRC_PGTO_MANUAL> BEG_CRC_PGTO_MANUAL { get; set; }

        public DbSet<BEG_CRC_PGTO_MANUAL_TITULO> BEG_CRC_PGTO_MANUAL_TITULO { get; set; }

        public DbSet<BEG_CRC_PGTO_SIMPLIF> BEG_CRC_PGTO_SIMPLIF { get; set; }

        public DbSet<BEG_CRC_SEQ_HIST> BEG_CRC_SEQ_HIST { get; set; }

        public DbSet<BEG_CRC_TITULO> BEG_CRC_TITULO { get; set; }

        public DbSet<BEG_CRC_TPMOV> BEG_CRC_TPMOV { get; set; }

        public DbSet<BEG_CST_PRODUTO> BEG_CST_PRODUTO { get; set; }

        public DbSet<BEG_DADO_FILIAL> BEG_DADO_FILIAL { get; set; }

        public DbSet<BEG_DADOS_BANCARIOS> BEG_DADOS_BANCARIOS { get; set; }

        public DbSet<BEG_EMAILS_PROBLEMAS> BEG_EMAILS_PROBLEMAS { get; set; }

        public DbSet<BEG_EST_ACERTO_ESTOQUE> BEG_EST_ACERTO_ESTOQUE { get; set; }

        public DbSet<BEG_EST_ALMOXARIFADO> BEG_EST_ALMOXARIFADO { get; set; }

        public DbSet<BEG_EST_INVENTARIO> BEG_EST_INVENTARIO { get; set; }

        public DbSet<BEG_EST_INV_ESTOQUE> BEG_EST_INV_ESTOQUE { get; set; }

        public DbSet<BEG_EST_LOG_RESERVA> BEG_EST_LOG_RESERVA { get; set; }

        public DbSet<BEG_EST_LOTE> BEG_EST_LOTE { get; set; }

        public DbSet<BEG_EST_LOTE_LINHA> BEG_EST_LOTE_LINHA { get; set; }

        public DbSet<BEG_EST_MOVTO_ESTOQUE> BEG_EST_MOVTO_ESTOQUE { get; set; }

        public DbSet<BEG_ESTOQUE> BEG_ESTOQUE { get; set; }

        public DbSet<BEG_EST_TP_ALMOXARIFADO> BEG_EST_TP_ALMOXARIFADO { get; set; }

        public DbSet<BEG_EST_TP_ESPECIE> BEG_EST_TP_ESPECIE { get; set; }

        public DbSet<BEG_EST_TP_LOTE> BEG_EST_TP_LOTE { get; set; }

        public DbSet<BEG_FAT_NFS> BEG_FAT_NFS { get; set; }

        public DbSet<BEG_FAT_NFS_ITEM> BEG_FAT_NFS_ITEM { get; set; }

        public DbSet<BEG_FAT_NUM_NF> BEG_FAT_NUM_NF { get; set; }

        public DbSet<BEG_FIN_CAIXA> BEG_FIN_CAIXA { get; set; }

        public DbSet<BEG_FIN_CAIXA_CONTA> BEG_FIN_CAIXA_CONTA { get; set; }

        public DbSet<BEG_FIN_CAIXA_HISTORICO> BEG_FIN_CAIXA_HISTORICO { get; set; }

        public DbSet<BEG_FIN_CAIXA_SALDO> BEG_FIN_CAIXA_SALDO { get; set; }

        public DbSet<BEG_FIN_CC_CONTA> BEG_FIN_CC_CONTA { get; set; }

        public DbSet<BEG_FIN_CC_HISTORICO> BEG_FIN_CC_HISTORICO { get; set; }

        public DbSet<BEG_FIN_CONTA_CORRENTE> BEG_FIN_CONTA_CORRENTE { get; set; }

        public DbSet<BEG_FIN_INF_PESSOA> BEG_FIN_INF_PESSOA { get; set; }

        public DbSet<BEG_FIN_PORTADOR> BEG_FIN_PORTADOR { get; set; }

        public DbSet<BEG_FIN_TIPO_DOCUMENTO> BEG_FIN_TIPO_DOCUMENTO { get; set; }

        public DbSet<BEG_FIS_CFOP> BEG_FIS_CFOP { get; set; }

        public DbSet<BEG_FIS_CNAE> BEG_FIS_CNAE { get; set; }

        public DbSet<BEG_FIS_DISPOSITIVO_LEGAL> BEG_FIS_DISPOSITIVO_LEGAL { get; set; }

        public DbSet<BEG_FIS_MATRIZ_TRIBUTARIA> BEG_FIS_MATRIZ_TRIBUTARIA { get; set; }

        public DbSet<BEG_FIS_MTZ_DISPOSITIVO> BEG_FIS_MTZ_DISPOSITIVO { get; set; }

        public DbSet<BEG_FIS_NCM> BEG_FIS_NCM { get; set; }

        public DbSet<BEG_FIS_ORIGEM_MERC> BEG_FIS_ORIGEM_MERC { get; set; }

        public DbSet<BEG_FIS_TP_NFS> BEG_FIS_TP_NFS { get; set; }

        public DbSet<BEG_FIS_TP_PEDIDO> BEG_FIS_TP_PEDIDO { get; set; }

        public DbSet<BEG_FIS_TRIB_ICMS> BEG_FIS_TRIB_ICMS { get; set; }

        public DbSet<BEG_FRO_ABASTECIMENTO> BEG_FRO_ABASTECIMENTO { get; set; }

        public DbSet<BEG_FRO_ABASTECIMENTO_PAGO> BEG_FRO_ABASTECIMENTO_PAGO { get; set; }

        public DbSet<BEG_FRO_DEFEITO> BEG_FRO_DEFEITO { get; set; }

        public DbSet<BEG_FRO_DESPESA> BEG_FRO_DESPESA { get; set; }

        public DbSet<BEG_FRO_MARCA_VEICULO> BEG_FRO_MARCA_VEICULO { get; set; }

        public DbSet<BEG_FRO_MATERIAL_OS> BEG_FRO_MATERIAL_OS { get; set; }

        public DbSet<BEG_FRO_MODELO_VEICULO> BEG_FRO_MODELO_VEICULO { get; set; }

        public DbSet<BEG_FRO_MOTORISTA> BEG_FRO_MOTORISTA { get; set; }

        public DbSet<BEG_FRO_OPERACAO> BEG_FRO_OPERACAO { get; set; }

        public DbSet<BEG_FRO_OPERACAO_OS> BEG_FRO_OPERACAO_OS { get; set; }

        public DbSet<BEG_FRO_OPERACAO_PADRAO> BEG_FRO_OPERACAO_PADRAO { get; set; }

        public DbSet<BEG_FRO_ORDEM_SERVICO> BEG_FRO_ORDEM_SERVICO { get; set; }

        public DbSet<BEG_FRO_PGTO_ABAST> BEG_FRO_PGTO_ABAST { get; set; }

        public DbSet<BEG_FRO_REVISAO> BEG_FRO_REVISAO { get; set; }

        public DbSet<BEG_FRO_ROTA> BEG_FRO_ROTA { get; set; }

        public DbSet<BEG_FRO_TIPO_VEICULO> BEG_FRO_TIPO_VEICULO { get; set; }

        public DbSet<BEG_FRO_TP_COBRANCA> BEG_FRO_TP_COBRANCA { get; set; }

        public DbSet<BEG_FRO_VEICULO> BEG_FRO_VEICULO { get; set; }

        public DbSet<BEG_GER_CONCEITO_PESSOA> BEG_GER_CONCEITO_PESSOA { get; set; }

        public DbSet<BEG_GER_DIVISAO_PEDIDO> BEG_GER_DIVISAO_PEDIDO { get; set; }

        public DbSet<BEG_GER_FILIAL> BEG_GER_FILIAL { get; set; }

        public DbSet<BEG_GER_IMPRESSAO> BEG_GER_IMPRESSAO { get; set; }

        public DbSet<BEG_GER_RUA_DIVISAO> BEG_GER_RUA_DIVISAO { get; set; }

        public DbSet<BEG_GER_TP_CONTATO> BEG_GER_TP_CONTATO { get; set; }

        public DbSet<BEG_GRUPO_CONVENIO> BEG_GRUPO_CONVENIO { get; set; }

        public DbSet<BEG_INFO_CLIENTE> BEG_INFO_CLIENTE { get; set; }

        public DbSet<BEG_INS_NFE_ITEM> BEG_INS_NFE_ITEM { get; set; }

        public DbSet<BEG_LOGRADOURO> BEG_LOGRADOURO { get; set; }

        public DbSet<BEG_MODULO_SISTEMA> BEG_MODULO_SISTEMA { get; set; }

        public DbSet<BEG_MOEDA> BEG_MOEDA { get; set; }

        public DbSet<BEG_MOTIVO_BAIXA> BEG_MOTIVO_BAIXA { get; set; }

        public DbSet<BEG_ORGAO_GERADOR> BEG_ORGAO_GERADOR { get; set; }

        public DbSet<BEG_PAIS> BEG_PAIS { get; set; }

        public DbSet<BEG_PARAMETRO_SISTEMA> BEG_PARAMETRO_SISTEMA { get; set; }

        public DbSet<BEG_PARCELA_CONDICAO> BEG_PARCELA_CONDICAO { get; set; }

        public DbSet<BEG_PCE_COMANDO_REM_PAG> BEG_PCE_COMANDO_REM_PAG { get; set; }

        public DbSet<BEG_PCE_LOTE_COBRANCA> BEG_PCE_LOTE_COBRANCA { get; set; }

        public DbSet<BEG_PCE_PAGAMENTO> BEG_PCE_PAGAMENTO { get; set; }

        public DbSet<BEG_PCE_PORTADOR_PGTO> BEG_PCE_PORTADOR_PGTO { get; set; }

        public DbSet<BEG_PESSOA> BEG_PESSOA { get; set; }

        public DbSet<BEG_PESSOA_ENDERECO> BEG_PESSOA_ENDERECO { get; set; }

        public DbSet<BEG_PESSOA_FILIAL> BEG_PESSOA_FILIAL { get; set; }

        public DbSet<BEG_PESSOA_OBS> BEG_PESSOA_OBS { get; set; }

        public DbSet<BEG_PESSOA_RELACIONADA> BEG_PESSOA_RELACIONADA { get; set; }

        public DbSet<BEG_PESSOA_RESTRICAO> BEG_PESSOA_RESTRICAO { get; set; }

        public DbSet<BEG_PRD_CATALOGO> BEG_PRD_CATALOGO { get; set; }

        public DbSet<BEG_PRD_CATALOGO_PRODUTO> BEG_PRD_CATALOGO_PRODUTO { get; set; }

        public DbSet<BEG_PRD_COMERCIAL> BEG_PRD_COMERCIAL { get; set; }

        public DbSet<BEG_PRD_COMERCIAL_CLASS> BEG_PRD_COMERCIAL_CLASS { get; set; }

        public DbSet<BEG_PRD_CONTABIL> BEG_PRD_CONTABIL { get; set; }

        public DbSet<BEG_PRD_CONTABIL_CLASS> BEG_PRD_CONTABIL_CLASS { get; set; }

        public DbSet<BEG_PRD_COR> BEG_PRD_COR { get; set; }

        public DbSet<BEG_PRD_ETIQUETA> BEG_PRD_ETIQUETA { get; set; }

        public DbSet<BEG_PRD_ETIQUETA_TIPO> BEG_PRD_ETIQUETA_TIPO { get; set; }

        public DbSet<BEG_PRD_FABRICANTE> BEG_PRD_FABRICANTE { get; set; }

        public DbSet<BEG_PRD_FISCAL_CLASS> BEG_PRD_FISCAL_CLASS { get; set; }

        public DbSet<BEG_PRD_FORNECEDOR> BEG_PRD_FORNECEDOR { get; set; }

        public DbSet<BEG_PRD_LOGISTICA> BEG_PRD_LOGISTICA { get; set; }

        public DbSet<BEG_PRD_MARCA> BEG_PRD_MARCA { get; set; }

        public DbSet<BEG_PRD_NBM> BEG_PRD_NBM { get; set; }

        public DbSet<BEG_PRD_NBM_NCM> BEG_PRD_NBM_NCM { get; set; }

        public DbSet<BEG_PRD_NCM> BEG_PRD_NCM { get; set; }

        public DbSet<BEG_PRD_PROMOCAO> BEG_PRD_PROMOCAO { get; set; }

        public DbSet<BEG_PRD_SITUACAO> BEG_PRD_SITUACAO { get; set; }

        public DbSet<BEG_PRD_SKU> BEG_PRD_SKU { get; set; }

        public DbSet<BEG_PRD_SKU_DETALHE> BEG_PRD_SKU_DETALHE { get; set; }

        public DbSet<BEG_PRD_SUPRIMENTO> BEG_PRD_SUPRIMENTO { get; set; }

        public DbSet<BEG_PRD_SUPRIMENTO_CLASS> BEG_PRD_SUPRIMENTO_CLASS { get; set; }

        public DbSet<BEG_PRD_TIPO> BEG_PRD_TIPO { get; set; }

        public DbSet<BEG_PRD_UNIDADE> BEG_PRD_UNIDADE { get; set; }

        public DbSet<BEG_PRD_VOLTAGEM> BEG_PRD_VOLTAGEM { get; set; }

        public DbSet<BEG_PRODUTO> BEG_PRODUTO { get; set; }

        public DbSet<BEG_REF_BANCARIA> BEG_REF_BANCARIA { get; set; }

        public DbSet<BEG_REF_COMERCIAL> BEG_REF_COMERCIAL { get; set; }

        public DbSet<BEG_REF_PESSOAL> BEG_REF_PESSOAL { get; set; }

        public DbSet<BEG_RESTRICAO> BEG_RESTRICAO { get; set; }

        public DbSet<BEG_SUP_FORNECEDOR> BEG_SUP_FORNECEDOR { get; set; }

        public DbSet<BEG_SUP_LISTA_FORNECEDOR> BEG_SUP_LISTA_FORNECEDOR { get; set; }

        public DbSet<BEG_TELEFONE> BEG_TELEFONE { get; set; }

        public DbSet<BEG_TIPO_TITULO> BEG_TIPO_TITULO { get; set; }

        public DbSet<BEG_TITULO_COBRADOR> BEG_TITULO_COBRADOR { get; set; }

        public DbSet<BEG_TMP_ARQUIVOS> BEG_TMP_ARQUIVOS { get; set; }

        public DbSet<BEG_TP_OBS> BEG_TP_OBS { get; set; }

        public DbSet<BEG_TP_PESSOA> BEG_TP_PESSOA { get; set; }

        public DbSet<BEG_UF> BEG_UF { get; set; }

        public DbSet<BEG_VEN_COM_MARGEM_PRODUTO> BEG_VEN_COM_MARGEM_PRODUTO { get; set; }

        public DbSet<BEG_VEN_DEFLATOR> BEG_VEN_DEFLATOR { get; set; }

        public DbSet<BEG_VEN_FORMA_COBRANCA> BEG_VEN_FORMA_COBRANCA { get; set; }

        public DbSet<BEG_VEN_FORMA_PAGAMENTO> BEG_VEN_FORMA_PAGAMENTO { get; set; }

        public DbSet<BEG_VEN_LINHA_PEDIDO> BEG_VEN_LINHA_PEDIDO { get; set; }

        public DbSet<BEG_VEN_PEDIDO> BEG_VEN_PEDIDO { get; set; }

        public DbSet<BEG_VEN_PEDIDO_CONFERIDO> BEG_VEN_PEDIDO_CONFERIDO { get; set; }

        public DbSet<BEG_VEN_PLANO_CONCEITO> BEG_VEN_PLANO_CONCEITO { get; set; }

        public DbSet<BEG_VEN_PLANO_VENDA> BEG_VEN_PLANO_VENDA { get; set; }

        public DbSet<BEG_VEN_PREPOSTO_FILIAL> BEG_VEN_PREPOSTO_FILIAL { get; set; }

        public DbSet<BEG_VEN_PRODUTO_DIVERGENTE> BEG_VEN_PRODUTO_DIVERGENTE { get; set; }

        public DbSet<BEG_VEN_PROMOCAO> BEG_VEN_PROMOCAO { get; set; }

        public DbSet<BEG_VEN_TIPO_PEDIDO> BEG_VEN_TIPO_PEDIDO { get; set; }

        public DbSet<TESTE_WEB> TESTE_WEB { get; set; }

        public DbSet<DIE_BEG_PESSOA> DIE_BEG_PESSOA { get; set; }

        public DbSet<BEG_COB_CONTATO> BEG_COB_CONTATO { get; set; }

        public DbSet<BEG_COB_CONTATO_TITULO> BEG_COB_CONTATO_TITULO { get; set; }

        public DbSet<BEG_COB_ENVIO_AVISO_LOG> BEG_COB_ENVIO_AVISO_LOG { get; set; }

        public DbSet<BEG_GER_TIPO_FILIAL> BEG_GER_TIPO_FILIAL { get; set; }

        public DbSet<BEG_TITULO_COBRADOR_HIST> BEG_TITULO_COBRADOR_HIST { get; set; }

        public DbSet<BEG_VEN_CONV_FAT_LOT> BEG_VEN_CONV_FAT_LOT { get; set; }

        public DbSet<BEG_VEN_CONV_FAT_LOT_ITEM> BEG_VEN_CONV_FAT_LOT_ITEM { get; set; }

        public DbSet<BEG_CRC_POSICAO_ATRASO> BEG_CRC_POSICAO_ATRASO { get; set; }

        public DbSet<DIE_CONTROLE_ATUALIZACAO> DIE_CONTROLE_ATUALIZACAO { get; set; }

        public DbSet<RECHIST> RECHIST { get; set; }

        public DbSet<SUBGRUPO> SUBGRUPO { get; set; }

        public DbSet<PRODUTO> PRODUTO { get; set; }

        public DbSet<DEPARA_MOTORISTA> DEPARA_MOTORISTA { get; set; }

        public DbSet<ITECOM> ITECOM { get; set; }

        public DbSet<DIE_LOG_TABELA> DIE_LOG_TABELA { get; set; }

        public DbSet<DIE_CONTAGEM_TABELA> DIE_CONTAGEM_TABELA { get; set; }

        public DbSet<DIE_VEN_META> DIE_VEN_META { get; set; }

        public DbSet<BEG_CRC_TITULO_ABERTO_ORG> BEG_CRC_TITULO_ABERTO_ORG { get; set; }

        public DbSet<DIE_VEN_META_GRUPO> DIE_VEN_META_GRUPO { get; set; }

        public DbSet<DIE_VEN_META_GRUPO_PRODUTO> DIE_VEN_META_GRUPO_PRODUTO { get; set; }

        public DbSet<DIE_VEN_REGIAO_LOJA> DIE_VEN_REGIAO_LOJA { get; set; }

        public DbSet<COR> COR { get; set; }

        public DbSet<DIE_FIN_BAIXA_LOJA_TMP> DIE_FIN_BAIXA_LOJA_TMP { get; set; }

        public DbSet<DIE_FAT_SERVICO> DIE_FAT_SERVICO { get; set; }

        public DbSet<LISTAPRECO> LISTAPRECO { get; set; }

        public DbSet<DIE_FECHAMENTO_LJA_TMP> DIE_FECHAMENTO_LJA_TMP { get; set; }

        public DbSet<DIE_FUNCIONARIO_TMP> DIE_FUNCIONARIO_TMP { get; set; }

        public DbSet<BEG_PRD_CARGA> BEG_PRD_CARGA { get; set; }

        public DbSet<FORNEC> FORNEC { get; set; }

        public DbSet<DIE_CRC_TIT_ABERTO_TMP> DIE_CRC_TIT_ABERTO_TMP { get; set; }

        public DbSet<VENDEDOR_BKP> VENDEDOR_BKP { get; set; }

        public DbSet<BEG_COB_PARAMETRO> BEG_COB_PARAMETRO { get; set; }

        public DbSet<BEG_COB_SPC> BEG_COB_SPC { get; set; }

        public DbSet<DDD> DDD { get; set; }

        public DbSet<DIE_CARGA_SPC_TMP> DIE_CARGA_SPC_TMP { get; set; }

        public DbSet<VENDA_DBF> VENDA_DBF { get; set; }

        public DbSet<BEG_DIST_SOLICITACAO> BEG_DIST_SOLICITACAO { get; set; }

        public DbSet<PAIS_3LETRAS> PAIS_3LETRAS { get; set; }

        public DbSet<PAIS_DDI> PAIS_DDI { get; set; }

        public DbSet<BEG_COB_TITULO_SPC> BEG_COB_TITULO_SPC { get; set; }

        public DbSet<BEG_COB_AVISO_PESSOA_HIST> BEG_COB_AVISO_PESSOA_HIST { get; set; }

        public DbSet<BEG_COB_AVISO_PESSOA> BEG_COB_AVISO_PESSOA { get; set; }

        public DbSet<BEG_COB_LOTE_SPC> BEG_COB_LOTE_SPC { get; set; }

        public DbSet<BEG_COB_LOTE_SPC_TIT> BEG_COB_LOTE_SPC_TIT { get; set; }

        public DbSet<DIE_CRC_POSICAO_ATRASO_TMP> DIE_CRC_POSICAO_ATRASO_TMP { get; set; }

        public DbSet<DIE_COB_DIVERGENCIA> DIE_COB_DIVERGENCIA { get; set; }

        public DbSet<DIE_CARTAO_PARCELA> DIE_CARTAO_PARCELA { get; set; }

        public DbSet<CPCRMOV_DBF> CPCRMOV_DBF { get; set; }

        public DbSet<CPCRITE_DBF> CPCRITE_DBF { get; set; }

        public DbSet<DIE_CARGA_COBRANCA_TMP> DIE_CARGA_COBRANCA_TMP { get; set; }

        public DbSet<CAIXAGAR> CAIXAGAR { get; set; }

        public DbSet<DIE_PRD_SUBGRUPO_GARANTIA> DIE_PRD_SUBGRUPO_GARANTIA { get; set; }

        public DbSet<DIE_GER_VENDEDOR> DIE_GER_VENDEDOR { get; set; }

        public DbSet<DIE_GER_SOLICITACAO> DIE_GER_SOLICITACAO { get; set; }

        public DbSet<ITEPRO> ITEPRO { get; set; }

        public DbSet<PROMOCAO> PROMOCAO { get; set; }

        public DbSet<BEG_CAR_UNIDADE> BEG_CAR_UNIDADE { get; set; }

        public DbSet<BEG_FPG_PESSOA> BEG_FPG_PESSOA { get; set; }

        public DbSet<DIE_COB_RESTR_CONTRATO> DIE_COB_RESTR_CONTRATO { get; set; }

        public DbSet<DIE_CAR_PREVISAO_PAGTO> DIE_CAR_PREVISAO_PAGTO { get; set; }

        public DbSet<DIE_CRC_POSICAO_AVENCER_TMP> DIE_CRC_POSICAO_AVENCER_TMP { get; set; }

        public DbSet<DIE_CAR_MOVTO_VENDA> DIE_CAR_MOVTO_VENDA { get; set; }

        public DbSet<DIE_CAR_CAPA_LOTE> DIE_CAR_CAPA_LOTE { get; set; }

        public DbSet<DIE_CAR_VENDA> DIE_CAR_VENDA { get; set; }

        public DbSet<RECLOJA> RECLOJA { get; set; }

        public DbSet<DIE_GER_PROCESSOS_LOG> DIE_GER_PROCESSOS_LOG { get; set; }

        public DbSet<DIE_CAR_VISA_REG2> DIE_CAR_VISA_REG2 { get; set; }

        public DbSet<PRODUTO_DBF> PRODUTO_DBF { get; set; }

        public DbSet<BEG_CEL_PLANO_PRODUTO> BEG_CEL_PLANO_PRODUTO { get; set; }

        public DbSet<BEG_COB_PARAMETRO_SPC> BEG_COB_PARAMETRO_SPC { get; set; }

        public DbSet<DIE_COB_SPC_CHEQUE> DIE_COB_SPC_CHEQUE { get; set; }

        public DbSet<DIE_COB_PESQUISA_CDL> DIE_COB_PESQUISA_CDL { get; set; }

        public DbSet<VENDEDOR> VENDEDOR { get; set; }

        public DbSet<DIE_CARGA_DIARIO_CLIENTE> DIE_CARGA_DIARIO_CLIENTE { get; set; }

        public DbSet<DIE_CRC_POS_ATR_GR_PLANO> DIE_CRC_POS_ATR_GR_PLANO { get; set; }

        public DbSet<DIE_CRC_CLIENTE_INATIVO> DIE_CRC_CLIENTE_INATIVO { get; set; }

        public DbSet<BEG_APEX_PERMISSOES> BEG_APEX_PERMISSOES { get; set; }

        public DbSet<BKN_FATURAMENTO_ESP> BKN_FATURAMENTO_ESP { get; set; }

        public DbSet<CARGA_DIARIO_CLI_TMP> CARGA_DIARIO_CLI_TMP { get; set; }

        public DbSet<DIE_CPR_PROJECAO> DIE_CPR_PROJECAO { get; set; }

        public DbSet<BEG_COB_PARAMETRO_CDL> BEG_COB_PARAMETRO_CDL { get; set; }

        public DbSet<DIE_SALDO_INVENTARIO> DIE_SALDO_INVENTARIO { get; set; }

        public DbSet<DIE_CAIXA> DIE_CAIXA { get; set; }

        public DbSet<DIE_SUBDES> DIE_SUBDES { get; set; }

        public DbSet<DIE_CTB_RESUMOTF> DIE_CTB_RESUMOTF { get; set; }

        public DbSet<DIE_CONTROLE_VP_ITEM> DIE_CONTROLE_VP_ITEM { get; set; }

        public DbSet<DIE_CARGA_DIARIO> DIE_CARGA_DIARIO { get; set; }

        public DbSet<DIE_SALDO_CONTABIL> DIE_SALDO_CONTABIL { get; set; }

        public DbSet<DIE_CARGA_DIARIO_CLI> DIE_CARGA_DIARIO_CLI { get; set; }

        public DbSet<DIE_CARGA_DIARIO_FOR> DIE_CARGA_DIARIO_FOR { get; set; }

        public DbSet<DIE_CARGA_DIARIO_CLI_LOG> DIE_CARGA_DIARIO_CLI_LOG { get; set; }

        public DbSet<DIE_CARGA_DIARIO_FOR_LOG> DIE_CARGA_DIARIO_FOR_LOG { get; set; }

        public DbSet<DIE_SALDO_CONTABIL_MENSAL> DIE_SALDO_CONTABIL_MENSAL { get; set; }

        public DbSet<DIE_CTB_CONTA_CONTABIL> DIE_CTB_CONTA_CONTABIL { get; set; }

        public DbSet<DIE_CAR_REDE_AUTORIZADORA> DIE_CAR_REDE_AUTORIZADORA { get; set; }

        public DbSet<BEG_CRC_POSICAO_ATRASO_BKP> BEG_CRC_POSICAO_ATRASO_BKP { get; set; }

        public DbSet<SMS> SMS { get; set; }

        public DbSet<DIE_PESSOA_CARTAO> DIE_PESSOA_CARTAO { get; set; }

        public DbSet<DIE_INDICADORES_TMP> DIE_INDICADORES_TMP { get; set; }

        public DbSet<DIE_SIM_TAXAS> DIE_SIM_TAXAS { get; set; }

        public DbSet<DIE_EST_LOJAS_TMP> DIE_EST_LOJAS_TMP { get; set; }

        public DbSet<DIE_INDICADORES> DIE_INDICADORES { get; set; }

        public DbSet<SALDO_JUNHO> SALDO_JUNHO { get; set; }

        public DbSet<DIE_PAGFOR_TMP> DIE_PAGFOR_TMP { get; set; }

        public DbSet<DIE_INDICADORES_VEND_TMP> DIE_INDICADORES_VEND_TMP { get; set; }

        public DbSet<DIE_FIN_CRED_BANC_HISTORICO> DIE_FIN_CRED_BANC_HISTORICO { get; set; }

        public DbSet<DIE_FIN_BAIXA_CRED_BANC> DIE_FIN_BAIXA_CRED_BANC { get; set; }

        public DbSet<BEG_GER_ANIVER_CLIENTE> BEG_GER_ANIVER_CLIENTE { get; set; }

        public DbSet<DIE_CAR_REDECARD_AUX> DIE_CAR_REDECARD_AUX { get; set; }

        public DbSet<BEG_TIPO_NF> BEG_TIPO_NF { get; set; }

        public DbSet<BEG_TP_NF_ESPEC> BEG_TP_NF_ESPEC { get; set; }

        public DbSet<DIE_CAR_TOTAIS_COMISSAO> DIE_CAR_TOTAIS_COMISSAO { get; set; }

        public DbSet<DIE_COB_TMA> DIE_COB_TMA { get; set; }

        public DbSet<FORNEC_DBF> FORNEC_DBF { get; set; }

        public DbSet<DIE_PRD_PROD_ENCOMENDA> DIE_PRD_PROD_ENCOMENDA { get; set; }

        public DbSet<DIE_VENDA_POR_EVENTO> DIE_VENDA_POR_EVENTO { get; set; }

        public DbSet<DIE_COB_TOTAIS_ABERTO> DIE_COB_TOTAIS_ABERTO { get; set; }

        public DbSet<FORLOJA> FORLOJA { get; set; }

        public DbSet<DIE_NOTA_CIAP> DIE_NOTA_CIAP { get; set; }

        public DbSet<DIE_ITEDEF> DIE_ITEDEF { get; set; }

        public DbSet<DIE_DEVFOR> DIE_DEVFOR { get; set; }

        public DbSet<DIE_CPCRMOV> DIE_CPCRMOV { get; set; }

        public DbSet<DIE_CPCRITE> DIE_CPCRITE { get; set; }

        public DbSet<DIE_NCM_MT> DIE_NCM_MT { get; set; }

        public DbSet<BEG_FIN_BCO_MOVTO> BEG_FIN_BCO_MOVTO { get; set; }

        public DbSet<BEG_FIN_BCO_SALDO> BEG_FIN_BCO_SALDO { get; set; }

        public DbSet<BEG_FIN_BCO_MOVTO_ORIGEM> BEG_FIN_BCO_MOVTO_ORIGEM { get; set; }

        public DbSet<DIE_FORLOJA> DIE_FORLOJA { get; set; }

        public DbSet<DIE_ITEAJU> DIE_ITEAJU { get; set; }

        public DbSet<CEP_F52> CEP_F52 { get; set; }

        public DbSet<FORA_LINHA> FORA_LINHA { get; set; }

        public DbSet<DIE_PEDIDO> DIE_PEDIDO { get; set; }

        public DbSet<DIE_ITEPED> DIE_ITEPED { get; set; }

        public DbSet<DIE_PEDPARC> DIE_PEDPARC { get; set; }

        public DbSet<DIE_COB_CLI_CONTATADOS> DIE_COB_CLI_CONTATADOS { get; set; }

        public DbSet<BKN_LISTA_REFERENCIA> BKN_LISTA_REFERENCIA { get; set; }

        public DbSet<DIE_POSICAO_GER_CLI> DIE_POSICAO_GER_CLI { get; set; }

        public DbSet<BEG_CPG_FECH_FORN_SPED> BEG_CPG_FECH_FORN_SPED { get; set; }

        public DbSet<DIE_NCM_ST> DIE_NCM_ST { get; set; }

        public DbSet<BEG_LOG_CTE> BEG_LOG_CTE { get; set; }

        public DbSet<MOVCAIXA> MOVCAIXA { get; set; }

        public DbSet<MOVBAN> MOVBAN { get; set; }

        public DbSet<DIE_CRC_FECHA_CONTABIL> DIE_CRC_FECHA_CONTABIL { get; set; }

        public DbSet<NEW_CEP> NEW_CEP { get; set; }

        public DbSet<DIE_CEP_CIDADES> DIE_CEP_CIDADES { get; set; }

        public DbSet<DIE_FIN_FECH_CAIXA_LJ_TMP> DIE_FIN_FECH_CAIXA_LJ_TMP { get; set; }

        public DbSet<DIE_F1_CONFERE_PEDIDO> DIE_F1_CONFERE_PEDIDO { get; set; }

        public DbSet<INCOBRAVEIS> INCOBRAVEIS { get; set; }

        public DbSet<DIE_FIN_EXTRATO_BANRI> DIE_FIN_EXTRATO_BANRI { get; set; }

        public DbSet<DIE_FIN_EXTRATO_BB> DIE_FIN_EXTRATO_BB { get; set; }

        public DbSet<DIE_CEP_BAIRROS> DIE_CEP_BAIRROS { get; set; }

        public DbSet<DIE_CEP_LOGRADOUROS> DIE_CEP_LOGRADOUROS { get; set; }

        public DbSet<ECF_ESTOQUES> ECF_ESTOQUES { get; set; }

        public DbSet<DIE_CARTAO_CR_FATURA> DIE_CARTAO_CR_FATURA { get; set; }

        public DbSet<DIE_CARTAO_CR_COMPRAS> DIE_CARTAO_CR_COMPRAS { get; set; }

        public DbSet<DIE_CARTAO_CR_HISTORICO> DIE_CARTAO_CR_HISTORICO { get; set; }

        public DbSet<DIE_CRC_CLI_ABERTO_CONTAB> DIE_CRC_CLI_ABERTO_CONTAB { get; set; }

        public DbSet<DIE_FECH_CAIXA_APEX_TEMP> DIE_FECH_CAIXA_APEX_TEMP { get; set; }

        public DbSet<DIE_FIN_CAIXA_MOVTO_TMP> DIE_FIN_CAIXA_MOVTO_TMP { get; set; }

        public DbSet<DIE_INDICADORES_VEND> DIE_INDICADORES_VEND { get; set; }

        public DbSet<DIE_FECH_TOT_APEX_TEMP> DIE_FECH_TOT_APEX_TEMP { get; set; }

        public DbSet<DIE_CRC_RENEG_OUTLJ> DIE_CRC_RENEG_OUTLJ { get; set; }

        public DbSet<ECF_REDUCOES> ECF_REDUCOES { get; set; }

        public DbSet<ECF_REDUCOES_PRODUTOS> ECF_REDUCOES_PRODUTOS { get; set; }

        public DbSet<ST_SC> ST_SC { get; set; }

        public DbSet<ITENS_CARTEIRA_VENDIDA> ITENS_CARTEIRA_VENDIDA { get; set; }

        public DbSet<DIE_REL_CLI_CREDZ> DIE_REL_CLI_CREDZ { get; set; }

        public DbSet<BASE_CLIENTES> BASE_CLIENTES { get; set; }

        public DbSet<NCM_CONVERSAO> NCM_CONVERSAO { get; set; }

        public DbSet<DIE_PROJ_COMPRAS_TMP> DIE_PROJ_COMPRAS_TMP { get; set; }

        public DbSet<DIE_FIN_FLUXO_CAIXA_TOTAL> DIE_FIN_FLUXO_CAIXA_TOTAL { get; set; }

        public DbSet<DIE_FAT_VEN_XML_TMP> DIE_FAT_VEN_XML_TMP { get; set; }

        public DbSet<DIE_CALC_MC_TMP> DIE_CALC_MC_TMP { get; set; }

        public DbSet<DIE_PED_PERC_CANC_TMP> DIE_PED_PERC_CANC_TMP { get; set; }

        public DbSet<DIE_EST_MEDIO_TMP> DIE_EST_MEDIO_TMP { get; set; }

        public DbSet<DIE_QTDDIAS_ENTR_TMP> DIE_QTDDIAS_ENTR_TMP { get; set; }

        public DbSet<DIE_FAT_CALC_CMV_TMP> DIE_FAT_CALC_CMV_TMP { get; set; }

        public DbSet<DIE_CALC_MC> DIE_CALC_MC { get; set; }

        public DbSet<DIE_COD_LOJA> DIE_COD_LOJA { get; set; }

        public DbSet<ASSESSORIA> ASSESSORIA { get; set; }

        public DbSet<PROTEA_DEVOLUCAO> PROTEA_DEVOLUCAO { get; set; }

        public DbSet<DIE_VW_COMISSAO_SERVICO_PF> DIE_VW_COMISSAO_SERVICO_PF { get; set; }

        public DbSet<DIE_VW_CURSO_ONLINE> DIE_VW_CURSO_ONLINE { get; set; }

        public DbSet<DIE_VW_TAB_ALIQ_IMP> DIE_VW_TAB_ALIQ_IMP { get; set; }

        public DbSet<PLANOCONTAS0091> PLANOCONTAS0091 { get; set; }

        public DbSet<DIE_TXT_VK> DIE_TXT_VK { get; set; }

        public DbSet<DIE_VW_EXTRATO_BANRI_141> DIE_VW_EXTRATO_BANRI_141 { get; set; }

        public DbSet<CLIENTES_CARTAOCR> CLIENTES_CARTAOCR { get; set; }

        public DbSet<CHEQUES_EXT> CHEQUES_EXT { get; set; }

        public DbSet<TOTAL_CARTEIRA_CDL> TOTAL_CARTEIRA_CDL { get; set; }

        public DbSet<CARGA_DIARIO_FOR> CARGA_DIARIO_FOR { get; set; }

        public DbSet<CARGA_DIARIO_TMP> CARGA_DIARIO_TMP { get; set; }

        public DbSet<DIE_NBM> DIE_NBM { get; set; }

        public DbSet<DIE_VW_COMISSAO_SERVICO> DIE_VW_COMISSAO_SERVICO { get; set; }

        public DbSet<DIE_PRD_CARGA_PRODUTO_NCM> DIE_PRD_CARGA_PRODUTO_NCM { get; set; }

        public DbSet<DIE_PRD_CARGA_PROD_ENCOMENDA> DIE_PRD_CARGA_PROD_ENCOMENDA { get; set; }

        public DbSet<DIE_ARQ_COMISSAO> DIE_ARQ_COMISSAO { get; set; }

        public DbSet<ARQUIVO_COMISSAO> ARQUIVO_COMISSAO { get; set; }

        public DbSet<CARGA_DIARIO_FOR_TMP> CARGA_DIARIO_FOR_TMP { get; set; }

        public DbSet<DIE_VW_COMISSAO_RESID> DIE_VW_COMISSAO_RESID { get; set; }

        public DbSet<DIE_VW_COMISSAO_AP> DIE_VW_COMISSAO_AP { get; set; }

        public DbSet<DIE_VW_CONCILIACAO_CIELO> DIE_VW_CONCILIACAO_CIELO { get; set; }

        public DbSet<CARGA_SALDOS_EZA_TMP> CARGA_SALDOS_EZA_TMP { get; set; }

        public DbSet<DIE_VW_CONCILIACAO_B2W> DIE_VW_CONCILIACAO_B2W { get; set; }

        public DbSet<CBO_FUNCAO> CBO_FUNCAO { get; set; }

        public DbSet<DIE_VW_F1_PEDIDOS> DIE_VW_F1_PEDIDOS { get; set; }

        public DbSet<DIE_VEN_CARTAO_CR> DIE_VEN_CARTAO_CR { get; set; }

        public DbSet<DIE_FUNCIONARIO_NEW1> DIE_FUNCIONARIO_NEW1 { get; set; }

        public DbSet<DIE_VW_EXTRATO_BB> DIE_VW_EXTRATO_BB { get; set; }

        public DbSet<DIE_VW_EXTRATO_BANRI> DIE_VW_EXTRATO_BANRI { get; set; }

        public DbSet<DIE_FUNCIONARIO> DIE_FUNCIONARIO { get; set; }

        public DbSet<DIE_NOTAS_EZA> DIE_NOTAS_EZA { get; set; }

        public DbSet<DIE_NOTAS_ITENS_EZA> DIE_NOTAS_ITENS_EZA { get; set; }

        public DbSet<TMP_DUDU_EXT_TAB> TMP_DUDU_EXT_TAB { get; set; }

        public DbSet<BRADESCO_EXT> BRADESCO_EXT { get; set; }

        public DbSet<DIE_CLI_FCDL> DIE_CLI_FCDL { get; set; }

        public DbSet<TMP_EDU_EXT_TAB> TMP_EDU_EXT_TAB { get; set; }

        public DbSet<DIE_CPR_ORDEM_TIT_ADIANT> DIE_CPR_ORDEM_TIT_ADIANT { get; set; }

        public DbSet<DIE_CPG_LOTE_ORDEM> DIE_CPG_LOTE_ORDEM { get; set; }

        public DbSet<BEG_CHQ_INCOBRAVEIS> BEG_CHQ_INCOBRAVEIS { get; set; }

        public DbSet<BEG_CHQ_REMESSA> BEG_CHQ_REMESSA { get; set; }

        public DbSet<BEG_CHQ_REMESSA_CHEQUE> BEG_CHQ_REMESSA_CHEQUE { get; set; }

        public DbSet<BEG_CPR_NFE_ITEM_FISCAL> BEG_CPR_NFE_ITEM_FISCAL { get; set; }

        public DbSet<BEG_CPR_NFE_FISCAL> BEG_CPR_NFE_FISCAL { get; set; }

        public DbSet<BEG_VW_PRD_PRECO_PENDENTE> BEG_VW_PRD_PRECO_PENDENTE { get; set; }

        public DbSet<BEG_VEN_CONV_REC_LOT_ITEM> BEG_VEN_CONV_REC_LOT_ITEM { get; set; }

        public DbSet<BEG_VEN_CONV_REC_LOT> BEG_VEN_CONV_REC_LOT { get; set; }

        public DbSet<BEG_COB_AVISO_FILIAL> BEG_COB_AVISO_FILIAL { get; set; }

        public DbSet<BEG_FPG_PESSOA_ESTAGIO> BEG_FPG_PESSOA_ESTAGIO { get; set; }

        public DbSet<DIE_PRD_GERADOR> DIE_PRD_GERADOR { get; set; }

        public DbSet<BEG_GER_REL_PADRAO_USUARIO> BEG_GER_REL_PADRAO_USUARIO { get; set; }

        public DbSet<BEG_COB_JURIDICO> BEG_COB_JURIDICO { get; set; }

        public DbSet<BEG_CEL_LOTE> BEG_CEL_LOTE { get; set; }

        public DbSet<BEG_CEL_LOTE_ITEM> BEG_CEL_LOTE_ITEM { get; set; }

        public DbSet<BEG_CEL_OCORRENCIA> BEG_CEL_OCORRENCIA { get; set; }

        public DbSet<BEG_CEL_ARQUIVO> BEG_CEL_ARQUIVO { get; set; }

        public DbSet<DIE_EST_DISTRIBUICAO> DIE_EST_DISTRIBUICAO { get; set; }

        public DbSet<DIE_EST_DISTRIBUICAO_FILIAL> DIE_EST_DISTRIBUICAO_FILIAL { get; set; }

        public DbSet<BEG_VEN_LINHA_PROMOCAO> BEG_VEN_LINHA_PROMOCAO { get; set; }

        public DbSet<BEG_VEN_AUTORIZACAO> BEG_VEN_AUTORIZACAO { get; set; }

        public DbSet<BEG_PRD_COMPOSICAO> BEG_PRD_COMPOSICAO { get; set; }

        public DbSet<BEG_BI_VEN_PRD_INFO> BEG_BI_VEN_PRD_INFO { get; set; }

        public DbSet<BEG_EST_MOVTI_ESTOQUE_INV> BEG_EST_MOVTI_ESTOQUE_INV { get; set; }

        public DbSet<BEG_VEN_PRECO_ANTERIOR_INATIVA> BEG_VEN_PRECO_ANTERIOR_INATIVA { get; set; }

        public DbSet<BEG_VEN_LIN_COTACAO> BEG_VEN_LIN_COTACAO { get; set; }

        public DbSet<BEG_PRD_ENDERECO> BEG_PRD_ENDERECO { get; set; }

        public DbSet<BEG_BI_CST_PRD_INFO> BEG_BI_CST_PRD_INFO { get; set; }

        public DbSet<BEG_EST_CONSULTA_MOVTO> BEG_EST_CONSULTA_MOVTO { get; set; }

        public DbSet<BEG_VEN_PRECO> BEG_VEN_PRECO { get; set; }

        public DbSet<BEG_BI_PRD_PRECO> BEG_BI_PRD_PRECO { get; set; }

        public DbSet<BEG_CPR_NEC_PARAM> BEG_CPR_NEC_PARAM { get; set; }

        public DbSet<BEG_PRD_SKU_CONVERSAO> BEG_PRD_SKU_CONVERSAO { get; set; }

        public DbSet<BEG_CPR_MOVIMENTO_MENSAL> BEG_CPR_MOVIMENTO_MENSAL { get; set; }

        public DbSet<BEG_AT_PRECO_TEMP> BEG_AT_PRECO_TEMP { get; set; }

        public DbSet<BEG_VEN_PRECO_NOVO_INATIVA> BEG_VEN_PRECO_NOVO_INATIVA { get; set; }

        public DbSet<BEG_ESTOQUE_BCK> BEG_ESTOQUE_BCK { get; set; }

        public DbSet<BEG_VEN_LINHA_PV_IMPORTADO> BEG_VEN_LINHA_PV_IMPORTADO { get; set; }

        public DbSet<BEG_VEN_CAMPANHA_LINHA> BEG_VEN_CAMPANHA_LINHA { get; set; }

        public DbSet<BEG_EST_RESUMO_ESTOQUE> BEG_EST_RESUMO_ESTOQUE { get; set; }

        public DbSet<BEG_PRD_COMPOSTO> BEG_PRD_COMPOSTO { get; set; }

        public DbSet<BEG_ESTOQUE_BCK_INV> BEG_ESTOQUE_BCK_INV { get; set; }

        public DbSet<BEG_CPR_NECESSIDADE> BEG_CPR_NECESSIDADE { get; set; }

        public DbSet<BEG_CPR_NECESSIDADE_ORG> BEG_CPR_NECESSIDADE_ORG { get; set; }

        public DbSet<BEG_VEN_TABELA_PRECO> BEG_VEN_TABELA_PRECO { get; set; }

        public DbSet<BEG_CTB_ACUM_CFOP> BEG_CTB_ACUM_CFOP { get; set; }

        public DbSet<BEG_CTB_ACUM_DOMINIO> BEG_CTB_ACUM_DOMINIO { get; set; }

        public DbSet<BEG_CRC_PGTO_SIMP_TITULO> BEG_CRC_PGTO_SIMP_TITULO { get; set; }

        public DbSet<BEG_TMP_PASTAS> BEG_TMP_PASTAS { get; set; }

        public DbSet<BEG_VEN_PAGAMENTO_COMISSAO> BEG_VEN_PAGAMENTO_COMISSAO { get; set; }

        public DbSet<BEG_VEN_COM_CRC_HISTORICO> BEG_VEN_COM_CRC_HISTORICO { get; set; }

        public DbSet<BEG_FIN_FLU_CONTA> BEG_FIN_FLU_CONTA { get; set; }

        public DbSet<BEG_VEN_LOTE_PEDIDO_PVS> BEG_VEN_LOTE_PEDIDO_PVS { get; set; }

        public DbSet<BEG_FRO_MOTOR_ESPEC> BEG_FRO_MOTOR_ESPEC { get; set; }

        public DbSet<BEG_PCE_PORTADOR_COBR> BEG_PCE_PORTADOR_COBR { get; set; }

        public DbSet<BEG_PCE_PORTADOR_BOLETO> BEG_PCE_PORTADOR_BOLETO { get; set; }

        public DbSet<BEG_FIN_REDIST_TITULO> BEG_FIN_REDIST_TITULO { get; set; }

        public DbSet<BEG_PCE_COBRANCA> BEG_PCE_COBRANCA { get; set; }

        public DbSet<BEG_PRD_EMBALAGEM> BEG_PRD_EMBALAGEM { get; set; }

        public DbSet<BEG_FRO_SEGURO_VEICULO> BEG_FRO_SEGURO_VEICULO { get; set; }

        public DbSet<BEG_INS_LIBERACAO> BEG_INS_LIBERACAO { get; set; }

        public DbSet<BEG_INS_LIBERACAO_ITEM> BEG_INS_LIBERACAO_ITEM { get; set; }

        public DbSet<BEG_VEN_ABORDAGEM> BEG_VEN_ABORDAGEM { get; set; }

        public DbSet<BEG_PCE_LOTE_COB_TIT> BEG_PCE_LOTE_COB_TIT { get; set; }

        public DbSet<BEG_FIN_REDISTRIBUICAO> BEG_FIN_REDISTRIBUICAO { get; set; }

        public DbSet<BEG_FRO_DESP_VIAGEM> BEG_FRO_DESP_VIAGEM { get; set; }

        public DbSet<BEG_FRO_TROCA_ODOM> BEG_FRO_TROCA_ODOM { get; set; }

        public DbSet<BEG_PCE_RETORNO_COBRANCA> BEG_PCE_RETORNO_COBRANCA { get; set; }

        public DbSet<BEG_VEN_COTACAO> BEG_VEN_COTACAO { get; set; }

        public DbSet<BEG_CPR_LIBERACAO> BEG_CPR_LIBERACAO { get; set; }

        public DbSet<BEG_CPG_PGTO_MANUAL_TITULO> BEG_CPG_PGTO_MANUAL_TITULO { get; set; }

        public DbSet<BEG_FIN_CC_MOVIMENTO> BEG_FIN_CC_MOVIMENTO { get; set; }

        public DbSet<BEG_GER_TIPO_TRANSP> BEG_GER_TIPO_TRANSP { get; set; }

    }
}
