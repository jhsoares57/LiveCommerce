
CREATE PROCEDURE LV_RELATORIO_CONTAS_PAGAS_V1
@DATAINICIAL DATE,
@DATAFINAL DATE
AS
BEGIN
SELECT V.CCODCONT [C�D],C.NOME_FANTASIA [NOME], V.CDTLANC [DT. LAN�.],
		V.CVLRCNT [VALOR], V.CDTVCTO [DT. VENCIMENTO],V.CDTPAG [DT. PAGAMENTO], V.COBS [OBSERVA��O]
		FROM CNTPGRC V 
		INNER JOIN FORNECEDOR C ON C.ID_FORNECEDOR = V.CCODORI
		INNER JOIN LTGEN L ON L.LTCOD = V.CTPCONT
		WHERE V.CTPCONT =1 
		AND L.LTTP =1 -- TIPO DO REGRISTRO NA LISTA GENERICA
		AND V.CSTATUS ='P'
		AND V.CDTPAG  BETWEEN @DATAINICIAL AND @DATAFINAL
END