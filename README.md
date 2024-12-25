# Documentação do Projeto ISO 20022

## Visão Geral
Este projeto implementa estruturas de mensagens financeiras baseadas no padrão **ISO 20022**. Essas mensagens são amplamente utilizadas para comunicação padronizada no setor financeiro, incluindo pagamentos, transferências de crédito, débito e transações de compensação.

---

## Sobre o ISO 20022
O **ISO 20022** é um padrão internacional para mensagens eletrônicas entre instituições financeiras. Ele fornece uma linguagem comum e formatos estruturados baseados em XML, usados globalmente.

### Benefícios:
- **Padronização Global**: Compatível em diversos mercados.
- **Extensibilidade**: Suporta adições e personalizações específicas.
- **Interoperabilidade**: Integração simplificada entre sistemas e redes.

### Tipos de Mensagens:
1. **PACS** - Pagamentos e Transferências (Payment Clearing and Settlement).
2. **PAIN** - Iniciação de Pagamentos (Payments Initiation).
3. **CAMT** - Gestão de Contas e Relatórios (Cash Management).
4. **SEMT** - Transferências de Títulos e Relatórios (Securities Management).

Cada tipo possui várias versões e variantes específicas para diferentes cenários e funcionalidades.

---

## Estrutura do Projeto

### Pastas e Arquivos:
- **PACS.Message/** - Contém as classes C# auto-geradas baseadas nos XSD.
- **XSD/** - Contém os esquemas XSD usados para gerar as classes.
- **mermaid_pacs_008.md** - Diagrama UML no formato Mermaid para visualização gráfica.

### Mensagens Suportadas:
- **pacs.008** - Transferência de Crédito (Credit Transfer)
- **pacs.002** - Relatório de Status de Pagamento (Payment Status Report)
- **pacs.004** - Devolução de Transferência (Payment Return)

---

## Exemplo - pacs.008 (Transferência de Crédito)
### Código para Geração de XML
```csharp
using System;
using System.IO;
using System.Xml.Serialization;

var document = new Document
{
    FIToFICstmrCdtTrf = new FIToFICustomerCreditTransferV09
    {
        GrpHdr = new GroupHeader93
        {
            MsgId = "12345",
            CreDtTm = DateTime.UtcNow
        },
        CdtTrfTxInf = new[]
        {
            new CreditTransferTransaction43
            {
                PmtId = new PaymentIdentification4 { InstrId = "Instr123", EndToEndId = "End123" },
                Amt = new ActiveCurrencyAndAmount { Ccy = "USD", Value = 1000.00m }
            }
        }
    }
};

var serializer = new XmlSerializer(typeof(Document));
using (var writer = new StreamWriter("pacs_008_output.xml"))
{
    serializer.Serialize(writer, document);
}
```

### Diagrama UML (Mermaid)
```mermaid
classDiagram
    class Document {
        +FIToFICstmrCdtTrf : FIToFICustomerCreditTransferV09
    }
    
    class FIToFICustomerCreditTransferV09 {
        +GrpHdr : GroupHeader93
        +CdtTrfTxInf : CreditTransferTransaction43[]
        +SplmtryData : SupplementaryData1[]
    }
    
    class GroupHeader93 {
        +MsgId : string
        +CreDtTm : DateTime
    }
    
    class CreditTransferTransaction43 {
        +PmtId : PaymentIdentification4
        +Amt : ActiveCurrencyAndAmount
        +Cdtr : PartyIdentification43
        +CdtrAcct : CashAccount24
        +RmtInf : RemittanceInformation11
    }
    
    class SupplementaryData1 {
        +PlcAndNm : string
        +Envlp : SupplementaryDataEnvelope1
    }
    
    class SupplementaryDataEnvelope1 {
        +Any : string
    }
    
    class PaymentIdentification4 {
        +InstrId : string
        +EndToEndId : string
    }
    
    class ActiveCurrencyAndAmount {
        +Ccy : string
        +Value : decimal
    }
    
    class PartyIdentification43 {
        +Nm : string
        +PstlAdr : PostalAddress6
    }
    
    class CashAccount24 {
        +Id : AccountIdentification4Choice
    }
    
    class RemittanceInformation11 {
        +Ustrd : string[]
    }
    
    class PostalAddress6 {
        +StrtNm : string
        +PstCd : string
        +TwnNm : string
        +Ctry : string
    }
    
    class AccountIdentification4Choice {
        +IBAN : string
    }
    
    Document --> FIToFICustomerCreditTransferV09
    FIToFICustomerCreditTransferV09 --> GroupHeader93
    FIToFICustomerCreditTransferV09 --> CreditTransferTransaction43
    FIToFICustomerCreditTransferV09 --> SupplementaryData1
    SupplementaryData1 --> SupplementaryDataEnvelope1
    CreditTransferTransaction43 --> PaymentIdentification4
    CreditTransferTransaction43 --> ActiveCurrencyAndAmount
    CreditTransferTransaction43 --> PartyIdentification43
    CreditTransferTransaction43 --> CashAccount24
    CreditTransferTransaction43 --> RemittanceInformation11
    PartyIdentification43 --> PostalAddress6
    CashAccount24 --> AccountIdentification4Choice
```

---

## Ferramentas Recomendadas
- **Visual Studio** - Para edição e depuração.
- **PlantUML** - Para visualizar e editar diagramas UML.
- **Mermaid Live Editor** - [https://mermaid.live](https://mermaid.live) para visualização de diagramas.

---

## Observações
- As classes foram geradas automaticamente e devem ser atualizadas conforme novas versões do XSD.
- As estruturas seguem o padrão ISO 20022, garantindo compatibilidade com sistemas financeiros.
- 

## ISO 20022

O **ISO 20022** é um padrão internacional para a troca eletrônica de dados entre instituições financeiras, abrangendo diversas áreas de negócios. Cada área é identificada por um código de quatro letras e contém mensagens específicas para diferentes processos financeiros. Abaixo, detalhamos cada área e listamos alguns dos tipos de mensagens correspondentes:

---

### **1. ACMT – Account Management (Gestão de Contas)**

Abrange mensagens relacionadas à abertura, manutenção e encerramento de contas bancárias.

- **acmt.001**: Account Opening Instruction (Instrução de Abertura de Conta)
- **acmt.002**: Account Opening Amendment Request (Solicitação de Alteração na Abertura de Conta)
- **acmt.003**: Account Closing Request (Solicitação de Encerramento de Conta)

---

### **2. ADMI – Administration (Administração)**

Inclui mensagens para administração e configuração de sistemas financeiros.

- **admi.001**: System Event Notification (Notificação de Evento do Sistema)
- **admi.002**: System Status Notification (Notificação de Status do Sistema)

---

### **3. AUTH – Authorities (Autoridades)**

Mensagens destinadas à comunicação com autoridades regulatórias ou fiscais.

- **auth.001**: Regulatory Report (Relatório Regulatório)
- **auth.002**: Tax Report (Relatório Fiscal)

---

### **4. CAAA – Acceptor to Acquirer Card Transactions (Transações com Cartão: Comerciante para Adquirente)**

Mensagens trocadas entre o ponto de venda e o adquirente durante transações com cartão.

- **caaa.001**: Authorization Request (Solicitação de Autorização)
- **caaa.002**: Authorization Response (Resposta de Autorização)

---

### **5. CAAD – Card Administration (Administração de Cartões)**

Envolve mensagens para a gestão e administração de cartões de pagamento.

- **caad.001**: Card Creation Request (Solicitação de Criação de Cartão)
- **caad.002**: Card Update Notification (Notificação de Atualização de Cartão)

---

### **6. CAAM – ATM Management (Gestão de ATM)**

Mensagens relacionadas à operação e manutenção de terminais ATM.

- **caam.001**: ATM Status Report (Relatório de Status do ATM)
- **caam.002**: ATM Device Management (Gestão de Dispositivos do ATM)

---

### **7. CAFC – Fee Collection (Cobrança de Taxas)**

Abrange mensagens para a cobrança e liquidação de taxas associadas a serviços financeiros.

- **cafc.001**: Fee Collection Request (Solicitação de Cobrança de Taxa)
- **cafc.002**: Fee Collection Report (Relatório de Cobrança de Taxa)

---

### **8. CAFM – File Management (Gestão de Arquivos)**

Inclui mensagens para a gestão e troca de arquivos entre instituições financeiras.

- **cafm.001**: File Upload Request (Solicitação de Upload de Arquivo)
- **cafm.002**: File Download Response (Resposta de Download de Arquivo)

---

### **9. CAFR – Fraud Reporting and Disposition (Relato e Disposição de Fraudes)**

Mensagens destinadas ao relato e gestão de casos de fraude.

- **cafr.001**: Fraud Report (Relatório de Fraude)
- **cafr.002**: Fraud Investigation Response (Resposta à Investigação de Fraude)

---

### **10. CAIN – Acquirer to Issuer Card Transactions (Transações com Cartão: Adquirente para Emissor)**

Mensagens trocadas entre o adquirente e o emissor durante o processamento de transações com cartão.

- **cain.001**: Transaction Authorization Request (Solicitação de Autorização de Transação)
- **cain.002**: Transaction Authorization Response (Resposta de Autorização de Transação)

---

### **11. CAMT – Cash Management (Gestão de Caixa)**

Envolve mensagens para a gestão de liquidez e informações de contas.

- **camt.052**: Bank to Customer Account Report (Relatório de Conta Banco para Cliente)
- **camt.053**: Bank to Customer Statement (Extrato Banco para Cliente)
- **camt.054**: Bank to Customer Debit/Credit Notification (Notificação de Débito/Crédito Banco para Cliente)

---

### **12. CANM – Network Management (Gestão de Rede)**

Mensagens relacionadas à gestão e configuração de redes de comunicação financeira.

- **canm.001**: Network Configuration Request (Solicitação de Configuração de Rede)
- **canm.002**: Network Status Report (Relatório de Status da Rede)

---

### **13. CASP – Sale to POI Card Transactions (Transações com Cartão: Venda para Ponto de Interação)**

Mensagens trocadas entre o sistema de vendas e o ponto de interação durante transações com cartão.

- **casp.001**: Payment Initiation Request (Solicitação de Iniciação de Pagamento)
- **casp.002**: Payment Initiation Response (Resposta de Iniciação de Pagamento)

---

### **14. CASR – Settlement Reporting (Relatório de Liquidação)**

Inclui mensagens para o relato de liquidações financeiras entre instituições.

- **casr.001**: Settlement Report (Relatório de Liquidação)
- **casr.002**: Settlement Status Notification (Notificação de Status de Liquidação)

---

### **15. CATM – Terminal Management (Gestão de Terminais)**

Mensagens para a gestão e manutenção de terminais de pagamento e ATMs.

- **catm.001**: Terminal Management Action Request (Solicitação de Ação de Gestão de Terminal)
- **catm.002**: Terminal Management Action Response (Resposta de Ação de Gestão de Terminal)

---

### **16. CATP – ATM Card Transactions (Transações com Cartão em ATM)**  
Mensagens utilizadas para transações realizadas em terminais ATM.  

- **catp.001**: Solicitação de Transação no ATM.  
- **catp.002**: Resposta de Transação no ATM.  

---

### **17. COLR – Collateral Management (Gestão de Garantias)**  
Mensagens relacionadas à administração e gerenciamento de garantias financeiras.  

- **colr.001**: Solicitação de Margem de Garantia.  
- **colr.002**: Confirmação de Transferência de Garantia.  
- **colr.003**: Relatório de Garantias.  

---

### **18. FXTR – Foreign Exchange Trade (Operações de Câmbio)**  
Mensagens destinadas a operações de câmbio, como compra e venda de moedas estrangeiras.  

- **fxtr.001**: Confirmação de Operação de Câmbio.  
- **fxtr.002**: Instrução de Liquidação de Câmbio.  

---

### **19. HEAD – Header Messages (Cabeçalhos de Mensagens)**  
Estruturas de cabeçalho usadas para transportar informações genéricas sobre mensagens ISO 20022.  

- **head.001**: Cabeçalho de Mensagem.  

---

### **20. PACS – Payments Clearing and Settlement (Pagamentos e Liquidação)**  
Mensagens relacionadas a pagamentos e processos de compensação.  

- **pacs.002**: Relatório de Status de Pagamento.  
- **pacs.004**: Devolução de Pagamento.  
- **pacs.008**: Transferência de Crédito.  
- **pacs.009**: Transferência de Débito.  

---

### **21. PAIN – Payments Initiation (Iniciação de Pagamentos)**  
Mensagens utilizadas para iniciar pagamentos por clientes.  

- **pain.001**: Iniciação de Pagamento por Cliente.  
- **pain.002**: Status de Instrução de Pagamento.  
- **pain.008**: Débito Direto por Cliente.  

---

### **22. REDA – Reference Data (Dados de Referência)**  
Mensagens relacionadas ao gerenciamento e fornecimento de dados de referência.  

- **reda.001**: Solicitação de Dados de Referência.  
- **reda.002**: Resposta de Dados de Referência.  

---

### **23. REMT – Remittance Advice (Avisos de Remessa)**  
Mensagens relacionadas à transmissão de informações sobre pagamentos e suas referências.  

- **remt.001**: Aviso de Remessa.  
- **remt.002**: Detalhamento de Informações de Remessa.  

---

### **24. SECL – Securities Clearing (Compensação de Títulos)**  
Mensagens relacionadas à compensação de transações com títulos.  

- **secl.001**: Confirmação de Compensação de Títulos.  
- **secl.002**: Liquidação de Títulos.  

---

### **25. SEEV – Securities Events (Eventos de Títulos)**  
Mensagens sobre eventos corporativos e notificações de mudanças em títulos.  

- **seev.001**: Notificação de Evento Corporativo.  
- **seev.002**: Detalhamento de Evento Corporativo.  

---

### **26. SEMT – Securities Management (Gestão de Títulos)**  
Mensagens relacionadas ao gerenciamento e posicionamento de títulos financeiros.  

- **semt.001**: Relatório de Posição de Títulos.  
- **semt.002**: Relatório de Movimentação de Títulos.  

---

### **27. SESE – Securities Settlement (Liquidação de Títulos)**  
Mensagens utilizadas para operações de liquidação e compensação de títulos.  

- **sese.023**: Instrução de Liquidação de Títulos.  
- **sese.025**: Status de Liquidação de Títulos.  

---

### **28. TSIN – Trade Services Initiation (Iniciação de Serviços de Comércio)**  
Mensagens para iniciar serviços relacionados a transações comerciais.  

- **tsin.001**: Solicitação de Iniciação de Serviço de Comércio.  
- **tsin.002**: Confirmação de Serviço de Comércio.  

---

### **29. TSMT – Trade Services Management (Gestão de Serviços de Comércio)**  
Mensagens utilizadas para gestão e acompanhamento de serviços relacionados a transações comerciais.  

- **tsmt.001**: Solicitação de Pedido de Compra.  
- **tsmt.002**: Resposta ao Pedido de Compra.  
- **tsmt.003**: Instrução de Remessa.  

---

## **Resumo Final**
As mensagens ISO 20022 são amplamente usadas para automatizar e padronizar transações financeiras em escala global. Cada categoria atende a uma necessidade específica, como pagamentos, títulos, compensação, câmbio e serviços comerciais.  

Se precisar de mais detalhes sobre uma categoria ou exemplo específico, é só avisar!

---

## Contato
Caso tenha dúvidas ou precise de suporte, entre em contato com devcomputariahub@exemplo.com.

