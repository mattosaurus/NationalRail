using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NationalRail.Models
{
    public enum Station
    {
        [Description("Abbey Wood")]
        ABW,
        [Description("Aber")]
        ABE,
        [Description("Abercynon")]
        ACY,
        [Description("Aberdare")]
        ABA,
        [Description("Aberdeen")]
        ABD,
        [Description("Aberdour")]
        AUR,
        [Description("Aberdovey")]
        AVY,
        [Description("Abererch")]
        ABH,
        [Description("Abergavenny")]
        AGV,
        [Description("Abergele & Pensarn")]
        AGL,
        [Description("Aberystwyth")]
        AYW,
        [Description("Accrington")]
        ACR,
        [Description("Achanalt")]
        AAT,
        [Description("Achnasheen")]
        ACN,
        [Description("Achnashellach")]
        ACH,
        [Description("Acklington")]
        ACK,
        [Description("Acle")]
        ACL,
        [Description("Acocks Green")]
        ACG,
        [Description("Acton Bridge (Cheshire)")]
        ACB,
        [Description("Acton Central")]
        ACC,
        [Description("Acton Main Line")]
        AML,
        [Description("Adderley Park")]
        ADD,
        [Description("Addiewell")]
        ADW,
        [Description("Addlestone")]
        ASN,
        [Description("Adisham")]
        ADM,
        [Description("Adlington (Cheshire)")]
        ADC,
        [Description("Adlington (Lancs)")]
        ADL,
        [Description("Adwick")]
        AWK,
        [Description("Aigburth")]
        AIG,
        [Description("Ainsdale")]
        ANS,
        [Description("Aintree")]
        AIN,
        [Description("Airbles")]
        AIR,
        [Description("Airdrie")]
        ADR,
        [Description("Albany Park")]
        AYP,
        [Description("Albrighton")]
        ALB,
        [Description("Alderley Edge")]
        ALD,
        [Description("Aldermaston")]
        AMT,
        [Description("Aldershot")]
        AHT,
        [Description("Aldrington")]
        AGT,
        [Description("Alexandra Palace")]
        AAP,
        [Description("Alexandra Parade")]
        AXP,
        [Description("Alexandria")]
        ALX,
        [Description("Alfreton")]
        ALF,
        [Description("Allens West")]
        ALW,
        [Description("Alloa")]
        ALO,
        [Description("Alness")]
        ASS,
        [Description("Alnmouth")]
        ALM,
        [Description("Alresford (Essex)")]
        ALR,
        [Description("Alsager")]
        ASG,
        [Description("Althorne (Essex)")]
        ALN,
        [Description("Althorpe")]
        ALP,
        [Description("Altnabreac")]
        ABC,
        [Description("Alton")]
        AON,
        [Description("Altrincham")]
        ALT,
        [Description("Alvechurch")]
        ALV,
        [Description("Ambergate")]
        AMB,
        [Description("Amberley")]
        AMY,
        [Description("Amersham")]
        AMR,
        [Description("Ammanford")]
        AMF,
        [Description("Ancaster")]
        ANC,
        [Description("Anderston")]
        AND,
        [Description("Andover")]
        ADV,
        [Description("Anerley")]
        ANZ,
        [Description("Angel Road")]
        AGR,
        [Description("Angmering")]
        ANG,
        [Description("Annan")]
        ANN,
        [Description("Anniesland")]
        ANL,
        [Description("Ansdell & Fairhaven")]
        AFV,
        [Description("Apperley Bridge")]
        APY,
        [Description("Appleby")]
        APP,
        [Description("Appledore (Kent)")]
        APD,
        [Description("Appleford")]
        APF,
        [Description("Appley Bridge")]
        APB,
        [Description("Apsley")]
        APS,
        [Description("Arbroath")]
        ARB,
        [Description("Ardgay")]
        ARD,
        [Description("Ardlui")]
        AUI,
        [Description("Ardrossan Harbour")]
        ADS,
        [Description("Ardrossan South Beach")]
        ASB,
        [Description("Ardrossan Town")]
        ADN,
        [Description("Ardwick")]
        ADK,
        [Description("Argyle Street")]
        AGS,
        [Description("Arisaig")]
        ARG,
        [Description("Arlesey")]
        ARL,
        [Description("Armadale (West Lothian)")]
        ARM,
        [Description("Armathwaite")]
        AWT,
        [Description("Arnside")]
        ARN,
        [Description("Arram")]
        ARR,
        [Description("Arrochar & Tarbet")]
        ART,
        [Description("Arundel")]
        ARU,
        [Description("Ascot (Berks)")]
        ACT,
        [Description("Ascott-under-Wychwood")]
        AUW,
        [Description("Ash")]
        ASH,
        [Description("Ash Vale")]
        AHV,
        [Description("Ashburys")]
        ABY,
        [Description("Ashchurch for Tewkesbury")]
        ASC,
        [Description("Ashfield")]
        ASF,
        [Description("Ashford (Surrey)")]
        AFS,
        [Description("Ashford International")]
        AFK,
        [Description("Ashford International (Eurostar)")]
        ASI,
        [Description("Ashley")]
        ASY,
        [Description("Ashtead")]
        AHD,
        [Description("Ashton-under-Lyne")]
        AHN,
        [Description("Ashurst (Kent)")]
        AHS,
        [Description("Ashurst New Forest")]
        ANF,
        [Description("Ashwell & Morden")]
        AWM,
        [Description("Askam")]
        ASK,
        [Description("Aslockton")]
        ALK,
        [Description("Aspatria")]
        ASP,
        [Description("Aspley Guise")]
        APG,
        [Description("Aston")]
        AST,
        [Description("Atherstone")]
        ATH,
        [Description("Atherton")]
        ATN,
        [Description("Attadale")]
        ATT,
        [Description("Attenborough")]
        ATB,
        [Description("Attleborough")]
        ATL,
        [Description("Auchinleck")]
        AUK,
        [Description("Audley End")]
        AUD,
        [Description("Aughton Park")]
        AUG,
        [Description("Aviemore")]
        AVM,
        [Description("Avoncliff")]
        AVF,
        [Description("Avonmouth")]
        AVN,
        [Description("Axminster")]
        AXM,
        [Description("Aylesbury")]
        AYS,
        [Description("Aylesbury Vale Parkway")]
        AVP,
        [Description("Aylesford")]
        AYL,
        [Description("Aylesham")]
        AYH,
        [Description("Ayr")]
        AYR,
        [Description("Bache")]
        BAC,
        [Description("Baglan")]
        BAJ,
        [Description("Bagshot")]
        BAG,
        [Description("Baildon")]
        BLD,
        [Description("Baillieston")]
        BIO,
        [Description("Balcombe")]
        BAB,
        [Description("Baldock")]
        BDK,
        [Description("Balham")]
        BAL,
        [Description("Balloch")]
        BHC,
        [Description("Balmossie")]
        BSI,
        [Description("Bamber Bridge")]
        BMB,
        [Description("Bamford")]
        BAM,
        [Description("Banavie")]
        BNV,
        [Description("Banbury")]
        BAN,
        [Description("Bangor (Gwynedd)")]
        BNG,
        [Description("Bank Hall")]
        BAH,
        [Description("Banstead")]
        BAD,
        [Description("Barassie")]
        BSS,
        [Description("Barbican")]
        ZBB,
        [Description("Bardon Mill")]
        BLL,
        [Description("Bare Lane")]
        BAR,
        [Description("Bargeddie")]
        BGI,
        [Description("Bargoed")]
        BGD,
        [Description("Barking")]
        BKG,
        [Description("Barlaston")]
        BRT,
        [Description("Barming")]
        BMG,
        [Description("Barmouth")]
        BRM,
        [Description("Barnehurst")]
        BNH,
        [Description("Barnes")]
        BNS,
        [Description("Barnes Bridge")]
        BNI,
        [Description("Barnetby")]
        BTB,
        [Description("Barnham")]
        BAA,
        [Description("Barnhill")]
        BNL,
        [Description("Barnsley")]
        BNY,
        [Description("Barnstaple")]
        BNP,
        [Description("Barnt Green")]
        BTG,
        [Description("Barrhead")]
        BRR,
        [Description("Barrhill")]
        BRL,
        [Description("Barrow Haven")]
        BAV,
        [Description("Barrow-in-Furness")]
        BIF,
        [Description("Barrow-Upon-Soar")]
        BWS,
        [Description("Barry")]
        BRY,
        [Description("Barry Docks")]
        BYD,
        [Description("Barry Island")]
        BYI,
        [Description("Barry Links")]
        BYL,
        [Description("Barton-on-Humber")]
        BAU,
        [Description("Basildon")]
        BSO,
        [Description("Basingstoke")]
        BSK,
        [Description("Bat & Ball")]
        BBL,
        [Description("Bath Spa")]
        BTH,
        [Description("Bathgate")]
        BHG,
        [Description("Batley")]
        BTL,
        [Description("Battersby")]
        BTT,
        [Description("Battersea Park")]
        BAK,
        [Description("Battle")]
        BAT,
        [Description("Battlesbridge")]
        BLB,
        [Description("Bayford")]
        BAY,
        [Description("Beaconsfield")]
        BCF,
        [Description("Bearley")]
        BER,
        [Description("Bearsden")]
        BRN,
        [Description("Bearsted")]
        BSD,
        [Description("Beasdale")]
        BSL,
        [Description("Beaulieu Road")]
        BEU,
        [Description("Beauly")]
        BEL,
        [Description("Bebington")]
        BEB,
        [Description("Beccles")]
        BCC,
        [Description("Beckenham Hill")]
        BEC,
        [Description("Beckenham Junction")]
        BKJ,
        [Description("Bedford")]
        BDM,
        [Description("Bedford St Johns")]
        BSJ,
        [Description("Bedhampton")]
        BDH,
        [Description("Bedminster")]
        BMT,
        [Description("Bedworth")]
        BEH,
        [Description("Bedwyn")]
        BDW,
        [Description("Beeston")]
        BEE,
        [Description("Bekesbourne")]
        BKS,
        [Description("Belle Vue")]
        BLV,
        [Description("Bellgrove")]
        BLG,
        [Description("Bellingham")]
        BGM,
        [Description("Bellshill")]
        BLH,
        [Description("Belmont")]
        BLM,
        [Description("Belper")]
        BLP,
        [Description("Beltring")]
        BEG,
        [Description("Belvedere")]
        BVD,
        [Description("Bempton")]
        BEM,
        [Description("Ben Rhydding")]
        BEY,
        [Description("Benfleet")]
        BEF,
        [Description("Bentham")]
        BEN,
        [Description("Bentley (Hants)")]
        BTY,
        [Description("Bentley (South Yorks)")]
        BYK,
        [Description("Bere Alston")]
        BAS,
        [Description("Bere Ferrers")]
        BFE,
        [Description("Berkhamsted")]
        BKM,
        [Description("Berkswell")]
        BKW,
        [Description("Bermuda Park")]
        BEP,
        [Description("Berney Arms")]
        BYA,
        [Description("Berry Brow")]
        BBW,
        [Description("Berrylands")]
        BRS,
        [Description("Berwick (Sussex)")]
        BRK,
        [Description("Berwick-upon-Tweed")]
        BWK,
        [Description("Bescar Lane")]
        BES,
        [Description("Bescot Stadium")]
        BSC,
        [Description("Betchworth")]
        BTO,
        [Description("Bethnal Green")]
        BET,
        [Description("Betws-y-Coed")]
        BYC,
        [Description("Beverley")]
        BEV,
        [Description("Bexhill")]
        BEX,
        [Description("Bexley")]
        BXY,
        [Description("Bexleyheath")]
        BXH,
        [Description("Bicester North")]
        BCS,
        [Description("Bicester Village")]
        BIT,
        [Description("Bickley")]
        BKL,
        [Description("Bidston")]
        BID,
        [Description("Biggleswade")]
        BIW,
        [Description("Bilbrook")]
        BBK,
        [Description("Billericay")]
        BIC,
        [Description("Billingham (Cleveland)")]
        BIL,
        [Description("Billingshurst")]
        BIG,
        [Description("Bingham")]
        BIN,
        [Description("Bingley")]
        BIY,
        [Description("Birchgrove")]
        BCG,
        [Description("Birchington-on-sea")]
        BCH,
        [Description("Birchwood")]
        BWD,
        [Description("Birkbeck")]
        BIK,
        [Description("Birkdale")]
        BDL,
        [Description("Birkenhead Central")]
        BKC,
        [Description("Birkenhead Hamilton Square")]
        BKQ,
        [Description("Birkenhead North")]
        BKN,
        [Description("Birkenhead Park")]
        BKP,
        [Description("Birmingham International")]
        BHI,
        [Description("Birmingham Moor Street")]
        BMO,
        [Description("Birmingham New Street")]
        BHM,
        [Description("Birmingham Snow Hill")]
        BSW,
        [Description("Bishop Auckland")]
        BIA,
        [Description("Bishopbriggs")]
        BBG,
        [Description("Bishops Stortford")]
        BIS,
        [Description("Bishopstone (Sussex)")]
        BIP,
        [Description("Bishopton (Strathclyde)")]
        BPT,
        [Description("Bitterne")]
        BTE,
        [Description("Blackburn")]
        BBN,
        [Description("Blackheath")]
        BKH,
        [Description("Blackhorse Road")]
        BHO,
        [Description("Blackpool North")]
        BPN,
        [Description("Blackpool Pleasure Beach")]
        BPB,
        [Description("Blackpool South")]
        BPS,
        [Description("Blackridge")]
        BKR,
        [Description("Blackrod")]
        BLK,
        [Description("Blackwater")]
        BAW,
        [Description("Blaenau Ffestiniog")]
        BFF,
        [Description("Blair Atholl")]
        BLA,
        [Description("Blairhill")]
        BAI,
        [Description("Blake Street")]
        BKT,
        [Description("Blakedown")]
        BKD,
        [Description("Blantyre")]
        BLT,
        [Description("Blaydon")]
        BLO,
        [Description("Bleasby")]
        BSB,
        [Description("Bletchley")]
        BLY,
        [Description("Bloxwich")]
        BLX,
        [Description("Bloxwich North")]
        BWN,
        [Description("Blundellsands & Crosby")]
        BLN,
        [Description("Blythe Bridge")]
        BYB,
        [Description("Bodmin Parkway")]
        BOD,
        [Description("Bodorgan")]
        BOR,
        [Description("Bognor Regis")]
        BOG,
        [Description("Bogston")]
        BGS,
        [Description("Bolton")]
        BON,
        [Description("Bolton-Upon-Dearne")]
        BTD,
        [Description("Bookham")]
        BKA,
        [Description("Bootle (Cumbria)")]
        BOC,
        [Description("Bootle New Strand")]
        BNW,
        [Description("Bootle Oriel Road")]
        BOT,
        [Description("Bordesley")]
        BBS,
        [Description("Borough Green & Wrotham")]
        BRG,
        [Description("Borth")]
        BRH,
        [Description("Bosham")]
        BOH,
        [Description("Boston")]
        BSN,
        [Description("Botley")]
        BOE,
        [Description("Bottesford")]
        BTF,
        [Description("Bourne End")]
        BNE,
        [Description("Bournemouth")]
        BMH,
        [Description("Bournville")]
        BRV,
        [Description("Bow Brickhill")]
        BWB,
        [Description("Bowes Park")]
        BOP,
        [Description("Bowling")]
        BWG,
        [Description("Box Hill & Westhumble")]
        BXW,
        [Description("Bracknell")]
        BCE,
        [Description("Bradford Forster Square")]
        BDQ,
        [Description("Bradford Interchange")]
        BDI,
        [Description("Bradford-on-Avon")]
        BOA,
        [Description("Brading")]
        BDN,
        [Description("Braintree")]
        BTR,
        [Description("Braintree Freeport")]
        BTP,
        [Description("Bramhall")]
        BML,
        [Description("Bramley (Hants)")]
        BMY,
        [Description("Bramley (W Yorks)")]
        BLE,
        [Description("Brampton (Cumbria)")]
        BMP,
        [Description("Brampton (Suffolk)")]
        BRP,
        [Description("Branchton")]
        BCN,
        [Description("Brandon")]
        BND,
        [Description("Branksome")]
        BSM,
        [Description("Braystones (Cumbria)")]
        BYS,
        [Description("Bredbury")]
        BDY,
        [Description("Breich")]
        BRC,
        [Description("Brentford")]
        BFD,
        [Description("Brentwood")]
        BRE,
        [Description("Bricket Wood")]
        BWO,
        [Description("Bridge of Allan")]
        BEA,
        [Description("Bridge of Orchy")]
        BRO,
        [Description("Bridgend")]
        BGN,
        [Description("Bridgeton")]
        BDG,
        [Description("Bridgwater")]
        BWT,
        [Description("Bridlington")]
        BDT,
        [Description("Brierfield")]
        BRF,
        [Description("Brigg")]
        BGG,
        [Description("Brighouse")]
        BGH,
        [Description("Brighton (East Sussex)")]
        BTN,
        [Description("Brimsdown")]
        BMD,
        [Description("Brinnington")]
        BNT,
        [Description("Bristol Parkway")]
        BPW,
        [Description("Bristol Temple Meads")]
        BRI,
        [Description("Brithdir")]
        BHD,
        [Description("Briton Ferry")]
        BNF,
        [Description("Brixton")]
        BRX,
        [Description("Broad Green")]
        BGE,
        [Description("Broadbottom")]
        BDB,
        [Description("Broadstairs")]
        BSR,
        [Description("Brockenhurst")]
        BCU,
        [Description("Brockholes")]
        BHS,
        [Description("Brockley")]
        BCY,
        [Description("Bromborough")]
        BOM,
        [Description("Bromborough Rake")]
        BMR,
        [Description("Bromley Cross (Lancs)")]
        BMC,
        [Description("Bromley North")]
        BMN,
        [Description("Bromley South")]
        BMS,
        [Description("Bromsgrove")]
        BMV,
        [Description("Brondesbury")]
        BSY,
        [Description("Brondesbury Park")]
        BSP,
        [Description("Brookmans Park")]
        BPK,
        [Description("Brookwood")]
        BKO,
        [Description("Broome")]
        BME,
        [Description("Broomfleet")]
        BMF,
        [Description("Brora")]
        BRA,
        [Description("Brough")]
        BUH,
        [Description("Broughty Ferry")]
        BYF,
        [Description("Broxbourne")]
        BXB,
        [Description("Bruce Grove")]
        BCV,
        [Description("Brundall")]
        BDA,
        [Description("Brundall Gardens")]
        BGA,
        [Description("Brunstane")]
        BSU,
        [Description("Brunswick")]
        BRW,
        [Description("Bruton")]
        BRU,
        [Description("Bryn")]
        BYN,
        [Description("Buckenham (Norfolk)")]
        BUC,
        [Description("Buckley")]
        BCK,
        [Description("Bucknell")]
        BUK,
        [Description("Buckshaw Parkway")]
        BSV,
        [Description("Bugle")]
        BGL,
        [Description("Builth Road")]
        BHR,
        [Description("Bulwell")]
        BLW,
        [Description("Bures")]
        BUE,
        [Description("Burgess Hill")]
        BUG,
        [Description("Burley Park")]
        BUY,
        [Description("Burley-in-Wharfedale")]
        BUW,
        [Description("Burnage")]
        BNA,
        [Description("Burneside (Cumbria)")]
        BUD,
        [Description("Burnham (Bucks)")]
        BNM,
        [Description("Burnham-on-Crouch")]
        BUU,
        [Description("Burnley Barracks")]
        BUB,
        [Description("Burnley Central")]
        BNC,
        [Description("Burnley Manchester Road")]
        BYM,
        [Description("Burnside (Strathclyde)")]
        BUI,
        [Description("Burntisland")]
        BTS,
        [Description("Burscough Bridge")]
        BCB,
        [Description("Burscough Junction")]
        BCJ,
        [Description("Bursledon")]
        BUO,
        [Description("Burton Joyce")]
        BUJ,
        [Description("Burton-on-Trent")]
        BUT,
        [Description("Bury St Edmunds")]
        BSE,
        [Description("Busby")]
        BUS,
        [Description("Bush Hill Park")]
        BHK,
        [Description("Bushey")]
        BSH,
        [Description("Butlers Lane")]
        BUL,
        [Description("Buxted")]
        BXD,
        [Description("Buxton")]
        BUX,
        [Description("Byfleet & New Haw")]
        BFN,
        [Description("Bynea")]
        BYE,
        [Description("Cadoxton")]
        CAD,
        [Description("Caergwrle")]
        CGW,
        [Description("Caerphilly")]
        CPH,
        [Description("Caersws")]
        CWS,
        [Description("Caldercruix")]
        CAC,
        [Description("Caldicot")]
        CDT,
        [Description("Caledonian Rd & Barnsbury")]
        CIR,
        [Description("Calstock")]
        CSK,
        [Description("Cam & Dursley")]
        CDU,
        [Description("Camberley")]
        CAM,
        [Description("Camborne")]
        CBN,
        [Description("Cambridge")]
        CBG,
        [Description("Cambridge Heath")]
        CBH,
        [Description("Cambuslang")]
        CBL,
        [Description("Camden Road")]
        CMD,
        [Description("Camelon")]
        CMO,
        [Description("Canada Water")]
        ZCW,
        [Description("Canley")]
        CNL,
        [Description("Cannock")]
        CAO,
        [Description("Canonbury")]
        CNN,
        [Description("Canterbury East")]
        CBE,
        [Description("Canterbury West")]
        CBW,
        [Description("Cantley")]
        CNY,
        [Description("Capenhurst")]
        CPU,
        [Description("Carbis Bay")]
        CBB,
        [Description("Cardenden")]
        CDD,
        [Description("Cardiff Bay")]
        CDB,
        [Description("Cardiff Central")]
        CDF,
        [Description("Cardiff Queen Street")]
        CDQ,
        [Description("Cardonald")]
        CDO,
        [Description("Cardross")]
        CDR,
        [Description("Carfin")]
        CRF,
        [Description("Cark & Cartmel")]
        CAK,
        [Description("Carlisle")]
        CAR,
        [Description("Carlton")]
        CTO,
        [Description("Carluke")]
        CLU,
        [Description("Carmarthen")]
        CMN,
        [Description("Carmyle")]
        CML,
        [Description("Carnforth")]
        CNF,
        [Description("Carnoustie")]
        CAN,
        [Description("Carntyne")]
        CAY,
        [Description("Carpenders Park")]
        CPK,
        [Description("Carrbridge")]
        CAG,
        [Description("Carshalton")]
        CSH,
        [Description("Carshalton Beeches")]
        CSB,
        [Description("Carstairs")]
        CRS,
        [Description("Cartsdyke")]
        CDY,
        [Description("Castle Bar Park")]
        CBP,
        [Description("Castle Cary")]
        CLC,
        [Description("Castleford")]
        CFD,
        [Description("Castleton (Manchester)")]
        CAS,
        [Description("Castleton Moor")]
        CSM,
        [Description("Caterham")]
        CAT,
        [Description("Catford")]
        CTF,
        [Description("Catford Bridge")]
        CFB,
        [Description("Cathays")]
        CYS,
        [Description("Cathcart")]
        CCT,
        [Description("Cattal")]
        CTL,
        [Description("Causeland")]
        CAU,
        [Description("Cefn-y-Bedd")]
        CYB,
        [Description("Chadwell Heath")]
        CTH,
        [Description("Chafford Hundred Lakeside")]
        CFH,
        [Description("Chalfont & Latimer")]
        CFO,
        [Description("Chalkwell")]
        CHW,
        [Description("Chandlers Ford")]
        CFR,
        [Description("Chapel-en-le-Frith")]
        CEF,
        [Description("Chapelton (Devon)")]
        CPN,
        [Description("Chapeltown (South Yorks)")]
        CLN,
        [Description("Chappel & Wakes Colne")]
        CWC,
        [Description("Charing (Kent)")]
        CHG,
        [Description("Charing Cross (Glasgow)")]
        CHC,
        [Description("Charlbury")]
        CBY,
        [Description("Charlton")]
        CTN,
        [Description("Chartham")]
        CRT,
        [Description("Chassen Road")]
        CSR,
        [Description("Chatelherault")]
        CTE,
        [Description("Chatham")]
        CTM,
        [Description("Chathill")]
        CHT,
        [Description("Cheadle Hulme")]
        CHU,
        [Description("Cheam")]
        CHE,
        [Description("Cheddington")]
        CED,
        [Description("Chelford (Cheshire)")]
        CEL,
        [Description("Chelmsford")]
        CHM,
        [Description("Chelsfield")]
        CLD,
        [Description("Cheltenham Spa")]
        CNM,
        [Description("Chepstow")]
        CPW,
        [Description("Cherry Tree")]
        CYT,
        [Description("Chertsey")]
        CHY,
        [Description("Cheshunt")]
        CHN,
        [Description("Chessington North")]
        CSN,
        [Description("Chessington South")]
        CSS,
        [Description("Chester")]
        CTR,
        [Description("Chester Road")]
        CRD,
        [Description("Chesterfield")]
        CHD,
        [Description("Chester-le-Street")]
        CLS,
        [Description("Chestfield & Swalecliffe")]
        CSW,
        [Description("Chetnole")]
        CNO,
        [Description("Chichester")]
        CCH,
        [Description("Chilham")]
        CIL,
        [Description("Chilworth")]
        CHL,
        [Description("Chingford")]
        CHI,
        [Description("Chinley")]
        CLY,
        [Description("Chippenham")]
        CPM,
        [Description("Chipstead")]
        CHP,
        [Description("Chirk")]
        CRK,
        [Description("Chislehurst")]
        CIT,
        [Description("Chiswick")]
        CHK,
        [Description("Cholsey")]
        CHO,
        [Description("Chorley")]
        CRL,
        [Description("Chorleywood")]
        CLW,
        [Description("Christchurch")]
        CHR,
        [Description("Christs Hospital")]
        CHH,
        [Description("Church & Oswaldtwistle")]
        CTW,
        [Description("Church Fenton")]
        CHF,
        [Description("Church Stretton")]
        CTT,
        [Description("Cilmeri")]
        CIM,
        [Description("City Thameslink")]
        CTK,
        [Description("Clacton-on-Sea")]
        CLT,
        [Description("Clandon")]
        CLA,
        [Description("Clapham (North Yorkshire)")]
        CPY,
        [Description("Clapham High Street")]
        CLP,
        [Description("Clapham Junction")]
        CLJ,
        [Description("Clapton")]
        CPT,
        [Description("Clarbeston Road")]
        CLR,
        [Description("Clarkston")]
        CKS,
        [Description("Claverdon")]
        CLV,
        [Description("Claygate")]
        CLG,
        [Description("Cleethorpes")]
        CLE,
        [Description("Cleland")]
        CEA,
        [Description("Clifton (Manchester)")]
        CLI,
        [Description("Clifton Down")]
        CFN,
        [Description("Clitheroe")]
        CLH,
        [Description("Clock House")]
        CLK,
        [Description("Clunderwen")]
        CUW,
        [Description("Clydebank")]
        CYK,
        [Description("Coatbridge Central")]
        CBC,
        [Description("Coatbridge Sunnyside")]
        CBS,
        [Description("Coatdyke")]
        COA,
        [Description("Cobham & Stoke d'Abernon")]
        CSD,
        [Description("Codsall")]
        CSL,
        [Description("Cogan")]
        CGN,
        [Description("Colchester")]
        COL,
        [Description("Colchester Town")]
        CET,
        [Description("Coleshill Parkway")]
        CEH,
        [Description("Collingham")]
        CLM,
        [Description("Collington")]
        CLL,
        [Description("Colne")]
        CNE,
        [Description("Colwall")]
        CWL,
        [Description("Colwyn Bay")]
        CWB,
        [Description("Combe (Oxon)")]
        CME,
        [Description("Commondale")]
        COM,
        [Description("Congleton")]
        CNG,
        [Description("Conisbrough")]
        CNS,
        [Description("Connel Ferry")]
        CON,
        [Description("Conon Bridge")]
        CBD,
        [Description("Cononley")]
        CEY,
        [Description("Conway Park")]
        CNP,
        [Description("Conwy")]
        CNW,
        [Description("Cooden Beach")]
        COB,
        [Description("Cookham")]
        COO,
        [Description("Cooksbridge")]
        CBR,
        [Description("Coombe Junction Halt")]
        COE,
        [Description("Copplestone")]
        COP,
        [Description("Corbridge")]
        CRB,
        [Description("Corby")]
        COR,
        [Description("Corkerhill")]
        CKH,
        [Description("Corkickle")]
        CKL,
        [Description("Corpach")]
        CPA,
        [Description("Corrour")]
        CRR,
        [Description("Coryton")]
        COY,
        [Description("Coseley")]
        CSY,
        [Description("Cosford")]
        COS,
        [Description("Cosham")]
        CSA,
        [Description("Cottingham")]
        CGM,
        [Description("Cottingley")]
        COT,
        [Description("Coulsdon South")]
        CDS,
        [Description("Coulsdon Town")]
        CDN,
        [Description("Coventry")]
        COV,
        [Description("Coventry Arena")]
        CAA,
        [Description("Cowden (Kent)")]
        CWN,
        [Description("Cowdenbeath")]
        COW,
        [Description("Cradley Heath")]
        CRA,
        [Description("Craigendoran")]
        CGD,
        [Description("Cramlington")]
        CRM,
        [Description("Cranbrook (Devon)")]
        CBK,
        [Description("Craven Arms")]
        CRV,
        [Description("Crawley")]
        CRW,
        [Description("Crayford")]
        CRY,
        [Description("Crediton")]
        CDI,
        [Description("Cressing (Essex)")]
        CES,
        [Description("Cressington")]
        CSG,
        [Description("Creswell")]
        CWD,
        [Description("Crewe")]
        CRE,
        [Description("Crewkerne")]
        CKN,
        [Description("Crews Hill")]
        CWH,
        [Description("Crianlarich")]
        CNR,
        [Description("Criccieth")]
        CCC,
        [Description("Cricklewood")]
        CRI,
        [Description("Croftfoot")]
        CFF,
        [Description("Crofton Park")]
        CFT,
        [Description("Cromer")]
        CMR,
        [Description("Cromford")]
        CMF,
        [Description("Crookston")]
        CKT,
        [Description("Cross Gates")]
        CRG,
        [Description("Crossflatts")]
        CFL,
        [Description("Crosshill")]
        COI,
        [Description("Crosskeys")]
        CKY,
        [Description("Crossmyloof")]
        CMY,
        [Description("Croston")]
        CSO,
        [Description("Crouch Hill")]
        CRH,
        [Description("Crowborough")]
        COH,
        [Description("Crowhurst")]
        CWU,
        [Description("Crowle")]
        CWE,
        [Description("Crowthorne")]
        CRN,
        [Description("Croy")]
        CRO,
        [Description("Crystal Palace")]
        CYP,
        [Description("Cuddington")]
        CUD,
        [Description("Cuffley")]
        CUF,
        [Description("Culham")]
        CUM,
        [Description("Culrain")]
        CUA,
        [Description("Cumbernauld")]
        CUB,
        [Description("Cupar")]
        CUP,
        [Description("Curriehill")]
        CUH,
        [Description("Cuxton")]
        CUX,
        [Description("Cwmbach")]
        CMH,
        [Description("Cwmbran")]
        CWM,
        [Description("Cynghordy")]
        CYN,
        [Description("Dagenham Dock")]
        DDK,
        [Description("Daisy Hill")]
        DSY,
        [Description("Dalgety Bay")]
        DAG,
        [Description("Dalmally")]
        DAL,
        [Description("Dalmarnock")]
        DAK,
        [Description("Dalmeny")]
        DAM,
        [Description("Dalmuir")]
        DMR,
        [Description("Dalreoch")]
        DLR,
        [Description("Dalry")]
        DLY,
        [Description("Dalston (Cumbria)")]
        DLS,
        [Description("Dalston Junction")]
        DLJ,
        [Description("Dalston Kingsland")]
        DLK,
        [Description("Dalton (Cumbria)")]
        DLT,
        [Description("Dalwhinnie")]
        DLW,
        [Description("Danby")]
        DNY,
        [Description("Danescourt")]
        DCT,
        [Description("Danzey")]
        DZY,
        [Description("Darlington")]
        DAR,
        [Description("Darnall")]
        DAN,
        [Description("Darsham")]
        DSM,
        [Description("Dartford")]
        DFD,
        [Description("Darton")]
        DRT,
        [Description("Darwen")]
        DWN,
        [Description("Datchet")]
        DAT,
        [Description("Davenport")]
        DVN,
        [Description("Dawlish")]
        DWL,
        [Description("Dawlish Warren")]
        DWW,
        [Description("Deal")]
        DEA,
        [Description("Dean (Wilts)")]
        DEN,
        [Description("Deansgate")]
        DGT,
        [Description("Deganwy")]
        DGY,
        [Description("Deighton")]
        DHN,
        [Description("Delamere")]
        DLM,
        [Description("Denby Dale")]
        DBD,
        [Description("Denham")]
        DNM,
        [Description("Denham Golf Club")]
        DGC,
        [Description("Denmark Hill")]
        DMK,
        [Description("Dent")]
        DNT,
        [Description("Denton")]
        DTN,
        [Description("Deptford")]
        DEP,
        [Description("Derby")]
        DBY,
        [Description("Derby Road (Ipswich)")]
        DBR,
        [Description("Devonport (Devon)")]
        DPT,
        [Description("Devonport Dockyard")]
        DOC,
        [Description("Dewsbury")]
        DEW,
        [Description("Didcot Parkway")]
        DID,
        [Description("Digby & Sowton")]
        DIG,
        [Description("Dilton Marsh")]
        DMH,
        [Description("Dinas (Rhondda)")]
        DMG,
        [Description("Dinas Powys")]
        DNS,
        [Description("Dingle Road")]
        DGL,
        [Description("Dingwall")]
        DIN,
        [Description("Dinsdale")]
        DND,
        [Description("Dinting")]
        DTG,
        [Description("Disley")]
        DSL,
        [Description("Diss")]
        DIS,
        [Description("Dodworth")]
        DOD,
        [Description("Dolau")]
        DOL,
        [Description("Doleham")]
        DLH,
        [Description("Dolgarrog")]
        DLG,
        [Description("Dolwyddelan")]
        DWD,
        [Description("Doncaster")]
        DON,
        [Description("Dorchester South")]
        DCH,
        [Description("Dorchester West")]
        DCW,
        [Description("Dore & Totley")]
        DOR,
        [Description("Dorking (Main)")]
        DKG,
        [Description("Dorking Deepdene")]
        DPD,
        [Description("Dorking West")]
        DKT,
        [Description("Dormans")]
        DMS,
        [Description("Dorridge")]
        DDG,
        [Description("Dove Holes")]
        DVH,
        [Description("Dover Priory")]
        DVP,
        [Description("Dovercourt")]
        DVC,
        [Description("Dovey Junction")]
        DVY,
        [Description("Downham Market")]
        DOW,
        [Description("Drayton Green")]
        DRG,
        [Description("Drayton Park")]
        DYP,
        [Description("Drem")]
        DRM,
        [Description("Driffield")]
        DRF,
        [Description("Drigg")]
        DRI,
        [Description("Droitwich Spa")]
        DTW,
        [Description("Dronfield")]
        DRO,
        [Description("Drumchapel")]
        DMC,
        [Description("Drumfrochar")]
        DFR,
        [Description("Drumgelloch")]
        DRU,
        [Description("Drumry")]
        DMY,
        [Description("Dublin Ferryport")]
        DFP,
        [Description("Dublin Port - Stena")]
        DPS,
        [Description("Duddeston")]
        DUD,
        [Description("Dudley Port")]
        DDP,
        [Description("Duffield")]
        DFI,
        [Description("Duirinish")]
        DRN,
        [Description("Duke Street")]
        DST,
        [Description("Dullingham")]
        DUL,
        [Description("Dumbarton Central")]
        DBC,
        [Description("Dumbarton East")]
        DBE,
        [Description("Dumbreck")]
        DUM,
        [Description("Dumfries")]
        DMF,
        [Description("Dumpton Park")]
        DMP,
        [Description("Dunbar")]
        DUN,
        [Description("Dunblane")]
        DBL,
        [Description("Duncraig")]
        DCG,
        [Description("Dundee")]
        DEE,
        [Description("Dunfermline Queen Margaret")]
        DFL,
        [Description("Dunfermline Town")]
        DFE,
        [Description("Dunkeld & Birnam")]
        DKD,
        [Description("Dunlop")]
        DNL,
        [Description("Dunrobin Castle")]
        DNO,
        [Description("Dunston")]
        DOT,
        [Description("Dunton Green")]
        DNG,
        [Description("Durham")]
        DHM,
        [Description("Durrington-on-Sea")]
        DUR,
        [Description("Dyce")]
        DYC,
        [Description("Dyffryn Ardudwy")]
        DYF,
        [Description("Eaglescliffe")]
        EAG,
        [Description("Ealing Broadway")]
        EAL,
        [Description("Earlestown")]
        ERL,
        [Description("Earley")]
        EAR,
        [Description("Earlsfield")]
        EAD,
        [Description("Earlswood (Surrey)")]
        ELD,
        [Description("Earlswood (West Midlands)")]
        EWD,
        [Description("East Croydon")]
        ECR,
        [Description("East Didsbury")]
        EDY,
        [Description("East Dulwich")]
        EDW,
        [Description("East Farleigh")]
        EFL,
        [Description("East Garforth")]
        EGF,
        [Description("East Grinstead")]
        EGR,
        [Description("East Kilbride")]
        EKL,
        [Description("East Malling")]
        EML,
        [Description("East Midlands Parkway")]
        EMD,
        [Description("East Tilbury")]
        ETL,
        [Description("East Worthing")]
        EWR,
        [Description("Eastbourne")]
        EBN,
        [Description("Eastbrook")]
        EBK,
        [Description("Easterhouse")]
        EST,
        [Description("Eastham Rake")]
        ERA,
        [Description("Eastleigh")]
        ESL,
        [Description("Eastrington")]
        EGN,
        [Description("Ebbsfleet International")]
        EBD,
        [Description("Ebbw Vale Parkway")]
        EBV,
        [Description("Ebbw Vale Town")]
        EBB,
        [Description("Eccles (Manchester)")]
        ECC,
        [Description("Eccles Road")]
        ECS,
        [Description("Eccleston Park")]
        ECL,
        [Description("Edale")]
        EDL,
        [Description("Eden Park")]
        EDN,
        [Description("Edenbridge")]
        EBR,
        [Description("Edenbridge Town")]
        EBT,
        [Description("Edge Hill")]
        EDG,
        [Description("Edinburgh")]
        EDB,
        [Description("Edinburgh Park")]
        EDP,
        [Description("Edmonton Green")]
        EDR,
        [Description("Effingham Junction")]
        EFF,
        [Description("Eggesford")]
        EGG,
        [Description("Egham")]
        EGH,
        [Description("Egton")]
        EGT,
        [Description("Elephant & Castle")]
        EPH,
        [Description("Elephant & Castle (Underground)")]
        ZEL,
        [Description("Elgin")]
        ELG,
        [Description("Ellesmere Port")]
        ELP,
        [Description("Elmers End")]
        ELE,
        [Description("Elmstead Woods")]
        ESD,
        [Description("Elmswell")]
        ESW,
        [Description("Elsecar")]
        ELR,
        [Description("Elsenham (Essex)")]
        ESM,
        [Description("Elstree & Borehamwood")]
        ELS,
        [Description("Eltham")]
        ELW,
        [Description("Elton & Orston")]
        ELO,
        [Description("Ely")]
        ELY,
        [Description("Emerson Park")]
        EMP,
        [Description("Emsworth")]
        EMS,
        [Description("Energlyn & Churchill Park")]
        ECP,
        [Description("Enfield Chase")]
        ENC,
        [Description("Enfield Lock")]
        ENL,
        [Description("Enfield Town")]
        ENF,
        [Description("Entwistle")]
        ENT,
        [Description("Epsom (Surrey)")]
        EPS,
        [Description("Epsom Downs")]
        EPD,
        [Description("Erdington")]
        ERD,
        [Description("Eridge")]
        ERI,
        [Description("Erith")]
        ERH,
        [Description("Esher")]
        ESH,
        [Description("Eskbank")]
        EKB,
        [Description("Essex Road")]
        EXR,
        [Description("Etchingham")]
        ETC,
        [Description("Euxton Balshaw Lane")]
        EBA,
        [Description("Evesham")]
        EVE,
        [Description("Ewell East")]
        EWE,
        [Description("Ewell West")]
        EWW,
        [Description("Exeter Central")]
        EXC,
        [Description("Exeter St David's")]
        EXD,
        [Description("Exeter St Thomas")]
        EXT,
        [Description("Exhibition Centre (Glasgow)")]
        EXG,
        [Description("Exmouth")]
        EXM,
        [Description("Exton")]
        EXN,
        [Description("Eynsford")]
        EYN,
        [Description("Fairbourne")]
        FRB,
        [Description("Fairfield")]
        FRF,
        [Description("Fairlie")]
        FRL,
        [Description("Fairwater")]
        FRW,
        [Description("Falconwood")]
        FCN,
        [Description("Falkirk Grahamston")]
        FKG,
        [Description("Falkirk High")]
        FKK,
        [Description("Falls of Cruachan")]
        FOC,
        [Description("Falmer")]
        FMR,
        [Description("Falmouth Docks")]
        FAL,
        [Description("Falmouth Town")]
        FMT,
        [Description("Fareham")]
        FRM,
        [Description("Farnborough (Main)")]
        FNB,
        [Description("Farnborough North")]
        FNN,
        [Description("Farncombe")]
        FNC,
        [Description("Farnham")]
        FNH,
        [Description("Farningham Road")]
        FNR,
        [Description("Farnworth")]
        FNW,
        [Description("Farringdon")]
        ZFD,
        [Description("Fauldhouse")]
        FLD,
        [Description("Faversham")]
        FAV,
        [Description("Faygate")]
        FGT,
        [Description("Fazakerley")]
        FAZ,
        [Description("Fearn")]
        FRN,
        [Description("Featherstone")]
        FEA,
        [Description("Felixstowe")]
        FLX,
        [Description("Feltham")]
        FEL,
        [Description("Feniton")]
        FNT,
        [Description("Fenny Stratford")]
        FEN,
        [Description("Fernhill")]
        FER,
        [Description("Ferriby")]
        FRY,
        [Description("Ferryside")]
        FYS,
        [Description("Ffairfach")]
        FFA,
        [Description("Filey")]
        FIL,
        [Description("Filton Abbey Wood")]
        FIT,
        [Description("Finchley Road & Frognal")]
        FNY,
        [Description("Finsbury Park")]
        FPK,
        [Description("Finstock")]
        FIN,
        [Description("Fishbourne (Sussex)")]
        FSB,
        [Description("Fishersgate")]
        FSG,
        [Description("Fishguard & Goodwick")]
        FGW,
        [Description("Fishguard Harbour")]
        FGH,
        [Description("Fiskerton")]
        FSK,
        [Description("Fitzwilliam")]
        FZW,
        [Description("Five Ways")]
        FWY,
        [Description("Fleet")]
        FLE,
        [Description("Flimby")]
        FLM,
        [Description("Flint")]
        FLN,
        [Description("Flitwick")]
        FLT,
        [Description("Flixton")]
        FLI,
        [Description("Flowery Field")]
        FLF,
        [Description("Folkestone Central")]
        FKC,
        [Description("Folkestone West")]
        FKW,
        [Description("Ford")]
        FOD,
        [Description("Forest Gate")]
        FOG,
        [Description("Forest Hill")]
        FOH,
        [Description("Formby")]
        FBY,
        [Description("Forres")]
        FOR,
        [Description("Forsinard")]
        FRS,
        [Description("Fort Matilda")]
        FTM,
        [Description("Fort William")]
        FTW,
        [Description("Four Oaks")]
        FOK,
        [Description("Foxfield")]
        FOX,
        [Description("Foxton")]
        FXN,
        [Description("Frant")]
        FRT,
        [Description("Fratton")]
        FTN,
        [Description("Freshfield")]
        FRE,
        [Description("Freshford")]
        FFD,
        [Description("Frimley")]
        FML,
        [Description("Frinton-on-Sea")]
        FRI,
        [Description("Frizinghall")]
        FZH,
        [Description("Frodsham")]
        FRD,
        [Description("Frome")]
        FRO,
        [Description("Fulwell")]
        FLW,
        [Description("Furness Vale")]
        FNV,
        [Description("Furze Platt")]
        FZP,
        [Description("Gainsborough Central")]
        GNB,
        [Description("Gainsborough Lea Road")]
        GBL,
        [Description("Galashiels")]
        GAL,
        [Description("Garelochhead")]
        GCH,
        [Description("Garforth")]
        GRF,
        [Description("Gargrave")]
        GGV,
        [Description("Garrowhill")]
        GAR,
        [Description("Garscadden")]
        GRS,
        [Description("Garsdale")]
        GSD,
        [Description("Garston (Hertfordshire)")]
        GSN,
        [Description("Garswood")]
        GSW,
        [Description("Gartcosh")]
        GRH,
        [Description("Garth (Mid Glamorgan)")]
        GMG,
        [Description("Garth (Powys)")]
        GTH,
        [Description("Garve")]
        GVE,
        [Description("Gathurst")]
        GST,
        [Description("Gatley")]
        GTY,
        [Description("Gatwick Airport")]
        GTW,
        [Description("Georgemas Junction")]
        GGJ,
        [Description("Gerrards Cross")]
        GER,
        [Description("Gidea Park")]
        GDP,
        [Description("Giffnock")]
        GFN,
        [Description("Giggleswick")]
        GIG,
        [Description("Gilberdyke")]
        GBD,
        [Description("Gilfach Fargoed")]
        GFF,
        [Description("Gillingham (Dorset)")]
        GIL,
        [Description("Gillingham (Kent)")]
        GLM,
        [Description("Gilshochill")]
        GSC,
        [Description("Gipsy Hill")]
        GIP,
        [Description("Girvan")]
        GIR,
        [Description("Glaisdale")]
        GLS,
        [Description("Glan Conwy")]
        GCW,
        [Description("Glasgow Central")]
        GLC,
        [Description("Glasgow Queen Street")]
        GLQ,
        [Description("Glasshoughton")]
        GLH,
        [Description("Glazebrook")]
        GLZ,
        [Description("Gleneagles")]
        GLE,
        [Description("Glenfinnan")]
        GLF,
        [Description("Glengarnock")]
        GLG,
        [Description("Glenrothes with Thornton")]
        GLT,
        [Description("Glossop")]
        GLO,
        [Description("Gloucester")]
        GCR,
        [Description("Glynde")]
        GLY,
        [Description("Gobowen")]
        GOB,
        [Description("Godalming")]
        GOD,
        [Description("Godley")]
        GDL,
        [Description("Godstone")]
        GDN,
        [Description("Goldthorpe")]
        GOE,
        [Description("Golf Street")]
        GOF,
        [Description("Golspie")]
        GOL,
        [Description("Gomshall")]
        GOM,
        [Description("Goodmayes")]
        GMY,
        [Description("Goole")]
        GOO,
        [Description("Goostrey")]
        GTR,
        [Description("Gordon Hill")]
        GDH,
        [Description("Gorebridge")]
        GBG,
        [Description("Goring & Streatley")]
        GOR,
        [Description("Goring-by-Sea")]
        GBS,
        [Description("Gorton")]
        GTO,
        [Description("Gospel Oak")]
        GPO,
        [Description("Gourock")]
        GRK,
        [Description("Gowerton")]
        GWN,
        [Description("Goxhill")]
        GOX,
        [Description("Grange Park")]
        GPK,
        [Description("Grange-Over-Sands")]
        GOS,
        [Description("Grangetown (Cardiff)")]
        GTN,
        [Description("Grantham")]
        GRA,
        [Description("Grateley")]
        GRT,
        [Description("Gravelly Hill")]
        GVH,
        [Description("Gravesend")]
        GRV,
        [Description("Grays")]
        GRY,
        [Description("Great Ayton")]
        GTA,
        [Description("Great Bentley")]
        GRB,
        [Description("Great Chesterford")]
        GRC,
        [Description("Great Coates")]
        GCT,
        [Description("Great Malvern")]
        GMV,
        [Description("Great Missenden")]
        GMN,
        [Description("Great Yarmouth")]
        GYM,
        [Description("Green Lane")]
        GNL,
        [Description("Green Road")]
        GNR,
        [Description("Greenbank")]
        GBK,
        [Description("Greenfaulds")]
        GRL,
        [Description("Greenfield")]
        GNF,
        [Description("Greenford")]
        GFD,
        [Description("Greenhithe")]
        GNH,
        [Description("Greenock Central")]
        GKC,
        [Description("Greenock West")]
        GKW,
        [Description("Greenwich")]
        GNW,
        [Description("Gretna Green")]
        GEA,
        [Description("Grimsby Docks")]
        GMD,
        [Description("Grimsby Town")]
        GMB,
        [Description("Grindleford")]
        GRN,
        [Description("Grosmont")]
        GMT,
        [Description("Grove Park")]
        GRP,
        [Description("Guide Bridge")]
        GUI,
        [Description("Guildford")]
        GLD,
        [Description("Guiseley")]
        GSY,
        [Description("Gunnersbury")]
        GUN,
        [Description("Gunnislake")]
        GSL,
        [Description("Gunton")]
        GNT,
        [Description("Gwersyllt")]
        GWE,
        [Description("Gypsy Lane")]
        GYP,
        [Description("Habrough")]
        HAB,
        [Description("Hackbridge")]
        HCB,
        [Description("Hackney Central")]
        HKC,
        [Description("Hackney Downs")]
        HAC,
        [Description("Hackney Wick")]
        HKW,
        [Description("Haddenham & Thame Parkway")]
        HDM,
        [Description("Haddiscoe")]
        HAD,
        [Description("Hadfield")]
        HDF,
        [Description("Hadley Wood")]
        HDW,
        [Description("Hag Fold")]
        HGF,
        [Description("Haggerston")]
        HGG,
        [Description("Hagley")]
        HAG,
        [Description("Hairmyres")]
        HMY,
        [Description("Hale (Manchester)")]
        HAL,
        [Description("Halesworth")]
        HAS,
        [Description("Halewood")]
        HED,
        [Description("Halifax")]
        HFX,
        [Description("Hall Green")]
        HLG,
        [Description("Hall Road")]
        HLR,
        [Description("Halling")]
        HAI,
        [Description("Hall-i'-th'-Wood")]
        HID,
        [Description("Haltwhistle")]
        HWH,
        [Description("Ham Street")]
        HMT,
        [Description("Hamble")]
        HME,
        [Description("Hamilton Central")]
        HNC,
        [Description("Hamilton West")]
        HNW,
        [Description("Hammerton")]
        HMM,
        [Description("Hampden Park (Sussex)")]
        HMD,
        [Description("Hampstead Heath")]
        HDH,
        [Description("Hampton (London)")]
        HMP,
        [Description("Hampton Court")]
        HMC,
        [Description("Hampton Wick")]
        HMW,
        [Description("Hampton-in-Arden")]
        HIA,
        [Description("Hamstead (Birmingham)")]
        HSD,
        [Description("Hamworthy")]
        HAM,
        [Description("Hanborough")]
        HND,
        [Description("Handforth")]
        HTH,
        [Description("Hanwell")]
        HAN,
        [Description("Hapton")]
        HPN,
        [Description("Harlech")]
        HRL,
        [Description("Harlesden")]
        HDN,
        [Description("Harling Road")]
        HRD,
        [Description("Harlington (Beds)")]
        HLN,
        [Description("Harlow Mill")]
        HWM,
        [Description("Harlow Town")]
        HWN,
        [Description("Harold Wood")]
        HRO,
        [Description("Harpenden")]
        HPD,
        [Description("Harrietsham")]
        HRM,
        [Description("Harringay")]
        HGY,
        [Description("Harringay Green Lanes")]
        HRY,
        [Description("Harrington")]
        HRR,
        [Description("Harrogate")]
        HGT,
        [Description("Harrow & Wealdstone")]
        HRW,
        [Description("Harrow-on-the-Hill")]
        HOH,
        [Description("Hartford (Cheshire)")]
        HTF,
        [Description("Hartlebury")]
        HBY,
        [Description("Hartlepool")]
        HPL,
        [Description("Hartwood")]
        HTW,
        [Description("Harwich International")]
        HPQ,
        [Description("Harwich Town")]
        HWC,
        [Description("Haslemere")]
        HSL,
        [Description("Hassocks")]
        HSK,
        [Description("Hastings")]
        HGS,
        [Description("Hatch End")]
        HTE,
        [Description("Hatfield & Stainforth")]
        HFS,
        [Description("Hatfield (Herts)")]
        HAT,
        [Description("Hatfield Peverel")]
        HAP,
        [Description("Hathersage")]
        HSG,
        [Description("Hattersley")]
        HTY,
        [Description("Hatton")]
        HTN,
        [Description("Havant")]
        HAV,
        [Description("Havenhouse")]
        HVN,
        [Description("Haverfordwest")]
        HVF,
        [Description("Hawarden")]
        HWD,
        [Description("Hawarden Bridge")]
        HWB,
        [Description("Hawkhead")]
        HKH,
        [Description("Haydon Bridge")]
        HDB,
        [Description("Haydons Road")]
        HYR,
        [Description("Hayes & Harlington")]
        HAY,
        [Description("Hayes (Kent)")]
        HYS,
        [Description("Hayle")]
        HYL,
        [Description("Haymarket")]
        HYM,
        [Description("Haywards Heath")]
        HHE,
        [Description("Hazel Grove")]
        HAZ,
        [Description("Headcorn")]
        HCN,
        [Description("Headingley")]
        HDY,
        [Description("Headstone Lane")]
        HDL,
        [Description("Heald Green")]
        HDG,
        [Description("Healing")]
        HLI,
        [Description("Heath High Level")]
        HHL,
        [Description("Heath Low Level")]
        HLL,
        [Description("Heathrow Airport Terminal 4")]
        HAF,
        [Description("Heathrow Airport Terminal 5")]
        HWV,
        [Description("Heathrow Airport Terminals 1, 2 and 3")]
        HXX,
        [Description("Heaton Chapel")]
        HTC,
        [Description("Hebden Bridge")]
        HBD,
        [Description("Heckington")]
        HEC,
        [Description("Hedge End")]
        HDE,
        [Description("Hednesford")]
        HNF,
        [Description("Heighington")]
        HEI,
        [Description("Helensburgh Central")]
        HLC,
        [Description("Helensburgh Upper")]
        HLU,
        [Description("Hellifield")]
        HLD,
        [Description("Helmsdale")]
        HMS,
        [Description("Helsby")]
        HSB,
        [Description("Hemel Hempstead")]
        HML,
        [Description("Hendon")]
        HEN,
        [Description("Hengoed")]
        HNG,
        [Description("Henley-in-Arden")]
        HNL,
        [Description("Henley-on-Thames")]
        HOT,
        [Description("Hensall")]
        HEL,
        [Description("Hereford")]
        HFD,
        [Description("Herne Bay")]
        HNB,
        [Description("Herne Hill")]
        HNH,
        [Description("Hersham")]
        HER,
        [Description("Hertford East")]
        HFE,
        [Description("Hertford North")]
        HFN,
        [Description("Hessle")]
        HES,
        [Description("Heswall")]
        HSW,
        [Description("Hever")]
        HEV,
        [Description("Heworth")]
        HEW,
        [Description("Hexham")]
        HEX,
        [Description("Heyford")]
        HYD,
        [Description("Heysham Port")]
        HHB,
        [Description("High Brooms")]
        HIB,
        [Description("High Street (Glasgow)")]
        HST,
        [Description("High Street Kensington Underground")]
        ZHS,
        [Description("High Wycombe")]
        HWY,
        [Description("Higham (Kent)")]
        HGM,
        [Description("Highams Park")]
        HIP,
        [Description("Highbridge & Burnham")]
        HIG,
        [Description("Highbury & Islington")]
        HHY,
        [Description("Hightown")]
        HTO,
        [Description("Hildenborough")]
        HLB,
        [Description("Hillfoot")]
        HLF,
        [Description("Hillington East")]
        HLE,
        [Description("Hillington West")]
        HLW,
        [Description("Hillside")]
        HIL,
        [Description("Hilsea")]
        HLS,
        [Description("Hinchley Wood")]
        HYW,
        [Description("Hinckley (Leics)")]
        HNK,
        [Description("Hindley")]
        HIN,
        [Description("Hinton Admiral")]
        HNA,
        [Description("Hitchin")]
        HIT,
        [Description("Hither Green")]
        HGR,
        [Description("Hockley")]
        HOC,
        [Description("Hollingbourne")]
        HBN,
        [Description("Holmes Chapel")]
        HCH,
        [Description("Holmwood")]
        HLM,
        [Description("Holton Heath")]
        HOL,
        [Description("Holyhead")]
        HHD,
        [Description("Holytown")]
        HLY,
        [Description("Homerton")]
        HMN,
        [Description("Honeybourne")]
        HYB,
        [Description("Honiton")]
        HON,
        [Description("Honley")]
        HOY,
        [Description("Honor Oak Park")]
        HPA,
        [Description("Hook")]
        HOK,
        [Description("Hooton")]
        HOO,
        [Description("Hope (Derbyshire)")]
        HOP,
        [Description("Hope (Flintshire)")]
        HPE,
        [Description("Hopton Heath")]
        HPT,
        [Description("Horley")]
        HOR,
        [Description("Hornbeam Park")]
        HBP,
        [Description("Hornsey")]
        HRN,
        [Description("Horsforth")]
        HRS,
        [Description("Horsham")]
        HRH,
        [Description("Horsley")]
        HSY,
        [Description("Horton-in-Ribblesdale")]
        HIR,
        [Description("Horwich Parkway")]
        HWI,
        [Description("Hoscar")]
        HSC,
        [Description("Hough Green")]
        HGN,
        [Description("Hounslow")]
        HOU,
        [Description("Hove")]
        HOV,
        [Description("Hoveton & Wroxham")]
        HXM,
        [Description("How Wood (Herts)")]
        HWW,
        [Description("Howden")]
        HOW,
        [Description("Howwood (Renfrewshire)")]
        HOZ,
        [Description("Hoxton")]
        HOX,
        [Description("Hoylake")]
        HYK,
        [Description("Hubberts Bridge")]
        HBB,
        [Description("Hucknall")]
        HKN,
        [Description("Huddersfield")]
        HUD,
        [Description("Hull")]
        HUL,
        [Description("Humphrey Park")]
        HUP,
        [Description("Huncoat")]
        HCT,
        [Description("Hungerford")]
        HGD,
        [Description("Hunmanby")]
        HUB,
        [Description("Huntingdon")]
        HUN,
        [Description("Huntly")]
        HNT,
        [Description("Hunts Cross")]
        HNX,
        [Description("Hurst Green")]
        HUR,
        [Description("Hutton Cranswick")]
        HUT,
        [Description("Huyton")]
        HUY,
        [Description("Hyde Central")]
        HYC,
        [Description("Hyde North")]
        HYT,
        [Description("Hykeham")]
        HKM,
        [Description("Hyndland")]
        HYN,
        [Description("Hythe (Essex)")]
        HYH,
        [Description("IBM Halt")]
        IBM,
        [Description("Ifield")]
        IFI,
        [Description("Ilford")]
        IFD,
        [Description("Ilkley")]
        ILK,
        [Description("Imperial Wharf")]
        IMW,
        [Description("Ince & Elton")]
        INE,
        [Description("Ince (Manchester)")]
        INC,
        [Description("Ingatestone")]
        INT,
        [Description("Insch")]
        INS,
        [Description("Invergordon")]
        IGD,
        [Description("Invergowrie")]
        ING,
        [Description("Inverkeithing")]
        INK,
        [Description("Inverkip")]
        INP,
        [Description("Inverness")]
        INV,
        [Description("Invershin")]
        INH,
        [Description("Inverurie")]
        INR,
        [Description("Ipswich")]
        IPS,
        [Description("Irlam")]
        IRL,
        [Description("Irvine")]
        IRV,
        [Description("Isleworth")]
        ISL,
        [Description("Islip")]
        ISP,
        [Description("Iver")]
        IVR,
        [Description("Ivybridge")]
        IVY,
        [Description("James Cook")]
        JCH,
        [Description("Jewellery Quarter")]
        JEQ,
        [Description("Johnston (Pembs)")]
        JOH,
        [Description("Johnstone (Strathclyde)")]
        JHN,
        [Description("Jordanhill")]
        JOR,
        [Description("Kearsley (Manchester)")]
        KSL,
        [Description("Kearsney (Kent)")]
        KSN,
        [Description("Keighley")]
        KEI,
        [Description("Keith")]
        KEH,
        [Description("Kelvedon")]
        KEL,
        [Description("Kelvindale")]
        KVD,
        [Description("Kemble")]
        KEM,
        [Description("Kempston Hardwick")]
        KMH,
        [Description("Kempton Park Racecourse")]
        KMP,
        [Description("Kemsing")]
        KMS,
        [Description("Kemsley")]
        KML,
        [Description("Kendal")]
        KEN,
        [Description("Kenley")]
        KLY,
        [Description("Kennett")]
        KNE,
        [Description("Kennishead")]
        KNS,
        [Description("Kensal Green")]
        KNL,
        [Description("Kensal Rise")]
        KNR,
        [Description("Kensington Olympia")]
        KPA,
        [Description("Kent House")]
        KTH,
        [Description("Kentish Town")]
        KTN,
        [Description("Kentish Town West")]
        KTW,
        [Description("Kenton")]
        KNT,
        [Description("Kents Bank")]
        KBK,
        [Description("Kettering")]
        KET,
        [Description("Kew Bridge")]
        KWB,
        [Description("Kew Gardens")]
        KWG,
        [Description("Keyham")]
        KEY,
        [Description("Keynsham")]
        KYN,
        [Description("Kidbrooke")]
        KDB,
        [Description("Kidderminster")]
        KID,
        [Description("Kidsgrove")]
        KDG,
        [Description("Kidwelly")]
        KWL,
        [Description("Kilburn High Road")]
        KBN,
        [Description("Kildale")]
        KLD,
        [Description("Kildonan")]
        KIL,
        [Description("Kilgetty")]
        KGT,
        [Description("Kilmarnock")]
        KMK,
        [Description("Kilmaurs")]
        KLM,
        [Description("Kilpatrick")]
        KPT,
        [Description("Kilwinning")]
        KWN,
        [Description("Kinbrace")]
        KBC,
        [Description("Kingham")]
        KGM,
        [Description("Kinghorn")]
        KGH,
        [Description("Kings Langley")]
        KGL,
        [Description("Kings Lynn")]
        KLN,
        [Description("Kings Norton")]
        KNN,
        [Description("Kings Nympton")]
        KGN,
        [Description("Kings Park")]
        KGP,
        [Description("Kings Sutton")]
        KGS,
        [Description("Kingsknowe")]
        KGE,
        [Description("Kingston")]
        KNG,
        [Description("Kingswood")]
        KND,
        [Description("Kingussie")]
        KIN,
        [Description("Kintbury")]
        KIT,
        [Description("Kirby Cross")]
        KBX,
        [Description("Kirk Sandall")]
        KKS,
        [Description("Kirkby (Merseyside)")]
        KIR,
        [Description("Kirkby Stephen")]
        KSW,
        [Description("Kirkby-in-Ashfield")]
        KKB,
        [Description("Kirkby-in-Furness")]
        KBF,
        [Description("Kirkcaldy")]
        KDY,
        [Description("Kirkconnel")]
        KRK,
        [Description("Kirkdale")]
        KKD,
        [Description("Kirkham & Wesham")]
        KKM,
        [Description("Kirkhill")]
        KKH,
        [Description("Kirknewton")]
        KKN,
        [Description("Kirkwood")]
        KWD,
        [Description("Kirton Lindsey")]
        KTL,
        [Description("Kiveton Bridge")]
        KIV,
        [Description("Kiveton Park")]
        KVP,
        [Description("Knaresborough")]
        KNA,
        [Description("Knebworth")]
        KBW,
        [Description("Knighton")]
        KNI,
        [Description("Knockholt")]
        KCK,
        [Description("Knottingley")]
        KNO,
        [Description("Knucklas")]
        KNU,
        [Description("Knutsford")]
        KNF,
        [Description("Kyle of Lochalsh")]
        KYL,
        [Description("Ladybank")]
        LDY,
        [Description("Ladywell")]
        LAD,
        [Description("Laindon")]
        LAI,
        [Description("Lairg")]
        LRG,
        [Description("Lake")]
        LKE,
        [Description("Lakenheath")]
        LAK,
        [Description("Lamphey")]
        LAM,
        [Description("Lanark")]
        LNK,
        [Description("Lancaster")]
        LAN,
        [Description("Lancing")]
        LAC,
        [Description("Landywood")]
        LAW,
        [Description("Langbank")]
        LGB,
        [Description("Langho")]
        LHO,
        [Description("Langley (Berks)")]
        LNY,
        [Description("Langley Green")]
        LGG,
        [Description("Langley Mill")]
        LGM,
        [Description("Langside")]
        LGS,
        [Description("Langwathby")]
        LGW,
        [Description("Langwith-Whaley Thorns")]
        LAG,
        [Description("Lapford")]
        LAP,
        [Description("Lapworth")]
        LPW,
        [Description("Larbert")]
        LBT,
        [Description("Largs")]
        LAR,
        [Description("Larkhall")]
        LRH,
        [Description("Laurencekirk")]
        LAU,
        [Description("Lawrence Hill")]
        LWH,
        [Description("Layton (Lancs)")]
        LAY,
        [Description("Lazonby & Kirkoswald")]
        LZB,
        [Description("Lea Bridge")]
        LEB,
        [Description("Lea Green")]
        LEG,
        [Description("Lea Hall")]
        LEH,
        [Description("Leagrave")]
        LEA,
        [Description("Lealholm")]
        LHM,
        [Description("Leamington Spa")]
        LMS,
        [Description("Leasowe")]
        LSW,
        [Description("Leatherhead")]
        LHD,
        [Description("Ledbury")]
        LED,
        [Description("Lee (London)")]
        LEE,
        [Description("Leeds")]
        LDS,
        [Description("Leicester")]
        LEI,
        [Description("Leigh (Kent)")]
        LIH,
        [Description("Leigh-on-Sea")]
        LES,
        [Description("Leighton Buzzard")]
        LBZ,
        [Description("Lelant")]
        LEL,
        [Description("Lelant Saltings")]
        LTS,
        [Description("Lenham")]
        LEN,
        [Description("Lenzie")]
        LNZ,
        [Description("Leominster")]
        LEO,
        [Description("Letchworth Garden City")]
        LET,
        [Description("Leuchars (for St. Andrews)")]
        LEU,
        [Description("Levenshulme")]
        LVM,
        [Description("Lewes")]
        LWS,
        [Description("Lewisham")]
        LEW,
        [Description("Leyland")]
        LEY,
        [Description("Leyton Midland Road")]
        LEM,
        [Description("Leytonstone High Road")]
        LER,
        [Description("Lichfield City")]
        LIC,
        [Description("Lichfield Trent Valley")]
        LTV,
        [Description("Lidlington")]
        LID,
        [Description("Limehouse")]
        LHS,
        [Description("Lincoln Central")]
        LCN,
        [Description("Lingfield")]
        LFD,
        [Description("Lingwood")]
        LGD,
        [Description("Linlithgow")]
        LIN,
        [Description("Liphook")]
        LIP,
        [Description("Liskeard")]
        LSK,
        [Description("Liss")]
        LIS,
        [Description("Lisvane & Thornhill")]
        LVT,
        [Description("Little Kimble")]
        LTK,
        [Description("Little Sutton")]
        LTT,
        [Description("Littleborough")]
        LTL,
        [Description("Littlehampton")]
        LIT,
        [Description("Littlehaven")]
        LVN,
        [Description("Littleport")]
        LTP,
        [Description("Liverpool Central")]
        LVC,
        [Description("Liverpool James Street")]
        LVJ,
        [Description("Liverpool Lime Street")]
        LIV,
        [Description("Liverpool South Parkway")]
        LPY,
        [Description("Livingston North")]
        LSN,
        [Description("Livingston South")]
        LVG,
        [Description("Llanaber")]
        LLA,
        [Description("Llanbedr")]
        LBR,
        [Description("Llanbister Road")]
        LLT,
        [Description("Llanbradach")]
        LNB,
        [Description("Llandaf")]
        LLN,
        [Description("Llandanwg")]
        LDN,
        [Description("Llandecwyn")]
        LLC,
        [Description("Llandeilo")]
        LLL,
        [Description("Llandovery")]
        LLV,
        [Description("Llandrindod")]
        LLO,
        [Description("Llandudno")]
        LLD,
        [Description("Llandudno Junction")]
        LLJ,
        [Description("Llandybie")]
        LLI,
        [Description("Llanelli")]
        LLE,
        [Description("Llanfairfechan")]
        LLF,
        [Description("Llanfairpwll")]
        LPG,
        [Description("Llangadog")]
        LLG,
        [Description("Llangammarch")]
        LLM,
        [Description("Llangennech")]
        LLH,
        [Description("Llangynllo")]
        LGO,
        [Description("Llanharan")]
        LLR,
        [Description("Llanhilleth")]
        LTH,
        [Description("Llanishen")]
        LLS,
        [Description("Llanrwst")]
        LWR,
        [Description("Llansamlet")]
        LAS,
        [Description("Llantwit Major")]
        LWM,
        [Description("Llanwrda")]
        LNR,
        [Description("Llanwrtyd")]
        LNW,
        [Description("Llwyngwril")]
        LLW,
        [Description("Llwynypia")]
        LLY,
        [Description("Loch Awe")]
        LHA,
        [Description("Loch Eil Outward Bound")]
        LHE,
        [Description("Lochailort")]
        LCL,
        [Description("Locheilside")]
        LCS,
        [Description("Lochgelly")]
        LCG,
        [Description("Lochluichart")]
        LCC,
        [Description("Lochwinnoch")]
        LHW,
        [Description("Lockerbie")]
        LOC,
        [Description("Lockwood")]
        LCK,
        [Description("London Blackfriars")]
        BFR,
        [Description("London Bridge")]
        LBG,
        [Description("London Cannon Street")]
        CST,
        [Description("London Charing Cross")]
        CHX,
        [Description("London Euston")]
        EUS,
        [Description("London Fenchurch Street")]
        FST,
        [Description("London Fields")]
        LOF,
        [Description("London Kings Cross")]
        KGX,
        [Description("London Liverpool Street")]
        LST,
        [Description("London Marylebone")]
        MYB,
        [Description("London Paddington")]
        PAD,
        [Description("London Road (Brighton)")]
        LRB,
        [Description("London Road (Guildford)")]
        LRD,
        [Description("London St Pancras (Intl)")]
        SPX,
        [Description("London St Pancras International")]
        STP,
        [Description("London Victoria")]
        VIC,
        [Description("London Waterloo")]
        WAT,
        [Description("London Waterloo East")]
        WAE,
        [Description("Long Buckby")]
        LBK,
        [Description("Long Eaton")]
        LGE,
        [Description("Long Preston")]
        LPR,
        [Description("Longbeck")]
        LGK,
        [Description("Longbridge")]
        LOB,
        [Description("Longcross")]
        LNG,
        [Description("Longfield")]
        LGF,
        [Description("Longniddry")]
        LND,
        [Description("Longport")]
        LPT,
        [Description("Longton")]
        LGN,
        [Description("Looe")]
        LOO,
        [Description("Lostock")]
        LOT,
        [Description("Lostock Gralam")]
        LTG,
        [Description("Lostock Hall")]
        LOH,
        [Description("Lostwithiel")]
        LOS,
        [Description("Loughborough")]
        LBO,
        [Description("Loughborough Junction")]
        LGJ,
        [Description("Lowdham")]
        LOW,
        [Description("Lower Sydenham")]
        LSY,
        [Description("Lowestoft")]
        LWT,
        [Description("Ludlow")]
        LUD,
        [Description("Luton")]
        LUT,
        [Description("Luton Airport Parkway")]
        LTN,
        [Description("Luxulyan")]
        LUX,
        [Description("Lydney")]
        LYD,
        [Description("Lye (West Midlands)")]
        LYE,
        [Description("Lymington Pier")]
        LYP,
        [Description("Lymington Town")]
        LYT,
        [Description("Lympstone Commando")]
        LYC,
        [Description("Lympstone Village")]
        LYM,
        [Description("Lytham")]
        LTM,
        [Description("Macclesfield")]
        MAC,
        [Description("Machynlleth")]
        MCN,
        [Description("Maesteg")]
        MST,
        [Description("Maesteg (Ewenny Road)")]
        MEW,
        [Description("Maghull")]
        MAG,
        [Description("Maiden Newton")]
        MDN,
        [Description("Maidenhead")]
        MAI,
        [Description("Maidstone Barracks")]
        MDB,
        [Description("Maidstone East")]
        MDE,
        [Description("Maidstone West")]
        MDW,
        [Description("Malden Manor")]
        MAL,
        [Description("Mallaig")]
        MLG,
        [Description("Malton")]
        MLT,
        [Description("Malvern Link")]
        MVL,
        [Description("Manchester Airport")]
        MIA,
        [Description("Manchester Oxford Road")]
        MCO,
        [Description("Manchester Piccadilly")]
        MAN,
        [Description("Manchester United Football Ground")]
        MUF,
        [Description("Manchester Victoria")]
        MCV,
        [Description("Manea")]
        MNE,
        [Description("Manningtree")]
        MNG,
        [Description("Manor Park")]
        MNP,
        [Description("Manor Road")]
        MNR,
        [Description("Manorbier")]
        MRB,
        [Description("Manors")]
        MAS,
        [Description("Mansfield")]
        MFT,
        [Description("Mansfield Woodhouse")]
        MSW,
        [Description("March")]
        MCH,
        [Description("Marden (Kent)")]
        MRN,
        [Description("Margate")]
        MAR,
        [Description("Market Harborough")]
        MHR,
        [Description("Market Rasen")]
        MKR,
        [Description("Markinch")]
        MNC,
        [Description("Marks Tey")]
        MKT,
        [Description("Marlow")]
        MLW,
        [Description("Marple")]
        MPL,
        [Description("Marsden (Yorks)")]
        MSN,
        [Description("Marske")]
        MSK,
        [Description("Marston Green")]
        MGN,
        [Description("Martin Mill")]
        MTM,
        [Description("Martins Heron")]
        MAO,
        [Description("Marton")]
        MTO,
        [Description("Maryhill")]
        MYH,
        [Description("Maryland")]
        MYL,
        [Description("Maryport")]
        MRY,
        [Description("Matlock")]
        MAT,
        [Description("Matlock Bath")]
        MTB,
        [Description("Mauldeth Road")]
        MAU,
        [Description("Maxwell Park")]
        MAX,
        [Description("Maybole")]
        MAY,
        [Description("Maze Hill")]
        MZH,
        [Description("Meadowhall")]
        MHS,
        [Description("Meldreth")]
        MEL,
        [Description("Melksham")]
        MKM,
        [Description("Melton (Suffolk)")]
        MES,
        [Description("Melton Mowbray")]
        MMO,
        [Description("Menheniot")]
        MEN,
        [Description("Menston")]
        MNN,
        [Description("Meols")]
        MEO,
        [Description("Meols Cop")]
        MEC,
        [Description("Meopham")]
        MEP,
        [Description("Merryton")]
        MEY,
        [Description("Merstham")]
        MHM,
        [Description("Merthyr Tydfil")]
        MER,
        [Description("Merthyr Vale")]
        MEV,
        [Description("Metheringham")]
        MGM,
        [Description("MetroCentre")]
        MCE,
        [Description("Mexborough")]
        MEX,
        [Description("Micheldever")]
        MIC,
        [Description("Micklefield")]
        MIK,
        [Description("Middlesbrough")]
        MBR,
        [Description("Middlewood")]
        MDL,
        [Description("Midgham")]
        MDG,
        [Description("Milford (Surrey)")]
        MLF,
        [Description("Milford Haven")]
        MFH,
        [Description("Mill Hill (Lancs)")]
        MLH,
        [Description("Mill Hill Broadway")]
        MIL,
        [Description("Millbrook (Beds)")]
        MLB,
        [Description("Millbrook (Hants)")]
        MBK,
        [Description("Milliken Park")]
        MIN,
        [Description("Millom")]
        MLM,
        [Description("Mills Hill (Manchester)")]
        MIH,
        [Description("Milngavie")]
        MLN,
        [Description("Milton Keynes Central")]
        MKC,
        [Description("Minffordd")]
        MFF,
        [Description("Minster")]
        MSR,
        [Description("Mirfield")]
        MIR,
        [Description("Mistley")]
        MIS,
        [Description("Mitcham Eastfields")]
        MTC,
        [Description("Mitcham Junction")]
        MIJ,
        [Description("Mobberley")]
        MOB,
        [Description("Monifieth")]
        MON,
        [Description("Monks Risborough")]
        MRS,
        [Description("Montpelier")]
        MTP,
        [Description("Montrose")]
        MTS,
        [Description("Moorfields")]
        MRF,
        [Description("Moorgate")]
        MOG,
        [Description("Moorside")]
        MSD,
        [Description("Moorthorpe")]
        MRP,
        [Description("Morar")]
        MRR,
        [Description("Morchard Road")]
        MRD,
        [Description("Morden South")]
        MDS,
        [Description("Morecambe")]
        MCM,
        [Description("Moreton (Dorset)")]
        MTN,
        [Description("Moreton (Merseyside)")]
        MRT,
        [Description("Moreton-in-Marsh")]
        MIM,
        [Description("Morfa Mawddach")]
        MFA,
        [Description("Morley")]
        MLY,
        [Description("Morpeth")]
        MPT,
        [Description("Mortimer")]
        MOR,
        [Description("Mortlake")]
        MTL,
        [Description("Moses Gate")]
        MSS,
        [Description("Moss Side")]
        MOS,
        [Description("Mossley (Manchester)")]
        MSL,
        [Description("Mossley Hill")]
        MSH,
        [Description("Mosspark")]
        MPK,
        [Description("Moston")]
        MSO,
        [Description("Motherwell")]
        MTH,
        [Description("Motspur Park")]
        MOT,
        [Description("Mottingham")]
        MTG,
        [Description("Mottisfont & Dunbridge")]
        DBG,
        [Description("Mouldsworth")]
        MLD,
        [Description("Moulsecoomb")]
        MCB,
        [Description("Mount Florida")]
        MFL,
        [Description("Mount Vernon")]
        MTV,
        [Description("Mountain Ash")]
        MTA,
        [Description("Muir of Ord")]
        MOO,
        [Description("Muirend")]
        MUI,
        [Description("Musselburgh")]
        MUB,
        [Description("Mytholmroyd")]
        MYT,
        [Description("Nafferton")]
        NFN,
        [Description("Nailsea & Backwell")]
        NLS,
        [Description("Nairn")]
        NRN,
        [Description("Nantwich")]
        NAN,
        [Description("Narberth")]
        NAR,
        [Description("Narborough")]
        NBR,
        [Description("Navigation Road")]
        NVR,
        [Description("Neath")]
        NTH,
        [Description("Needham Market")]
        NMT,
        [Description("Neilston")]
        NEI,
        [Description("Nelson")]
        NEL,
        [Description("Neston")]
        NES,
        [Description("Netherfield")]
        NET,
        [Description("Nethertown")]
        NRT,
        [Description("Netley")]
        NTL,
        [Description("New Barnet")]
        NBA,
        [Description("New Beckenham")]
        NBC,
        [Description("New Brighton")]
        NBN,
        [Description("New Clee")]
        NCE,
        [Description("New Cross")]
        NWX,
        [Description("New Cross Gate")]
        NXG,
        [Description("New Cumnock")]
        NCK,
        [Description("New Eltham")]
        NEH,
        [Description("New Holland")]
        NHL,
        [Description("New Hythe")]
        NHE,
        [Description("New Lane")]
        NLN,
        [Description("New Malden")]
        NEM,
        [Description("New Mills Central")]
        NMC,
        [Description("New Mills Newtown")]
        NMN,
        [Description("New Milton")]
        NWM,
        [Description("New Pudsey")]
        NPD,
        [Description("New Southgate")]
        NSG,
        [Description("Newark Castle")]
        NCT,
        [Description("Newark North Gate")]
        NNG,
        [Description("Newbridge")]
        NBE,
        [Description("Newbury")]
        NBY,
        [Description("Newbury Racecourse")]
        NRC,
        [Description("Newcastle")]
        NCL,
        [Description("Newcourt")]
        NCO,
        [Description("Newcraighall")]
        NEW,
        [Description("Newhaven Harbour")]
        NVH,
        [Description("Newhaven Town")]
        NVN,
        [Description("Newington")]
        NGT,
        [Description("Newmarket")]
        NMK,
        [Description("Newport (Essex)")]
        NWE,
        [Description("Newport (South Wales)")]
        NWP,
        [Description("Newquay")]
        NQY,
        [Description("Newstead")]
        NSD,
        [Description("Newton (Lanark)")]
        NTN,
        [Description("Newton Abbot")]
        NTA,
        [Description("Newton Aycliffe")]
        NAY,
        [Description("Newton for Hyde")]
        NWN,
        [Description("Newton St Cyres")]
        NTC,
        [Description("Newtongrange")]
        NEG,
        [Description("Newton-le-Willows")]
        NLW,
        [Description("Newtonmore")]
        NWR,
        [Description("Newton-on-Ayr")]
        NOA,
        [Description("Newtown (Powys)")]
        NWT,
        [Description("Ninian Park")]
        NNP,
        [Description("Nitshill")]
        NIT,
        [Description("Norbiton")]
        NBT,
        [Description("Norbury")]
        NRB,
        [Description("Normans Bay")]
        NSB,
        [Description("Normanton")]
        NOR,
        [Description("North Berwick")]
        NBW,
        [Description("North Camp")]
        NCM,
        [Description("North Dulwich")]
        NDL,
        [Description("North Fambridge")]
        NFA,
        [Description("North Llanrwst")]
        NLR,
        [Description("North Queensferry")]
        NQU,
        [Description("North Road (Darlington)")]
        NRD,
        [Description("North Sheen")]
        NSH,
        [Description("North Walsham")]
        NWA,
        [Description("North Wembley")]
        NWB,
        [Description("Northallerton")]
        NTR,
        [Description("Northampton")]
        NMP,
        [Description("Northfield")]
        NFD,
        [Description("Northfleet")]
        NFL,
        [Description("Northolt Park")]
        NLT,
        [Description("Northumberland Park")]
        NUM,
        [Description("Northwich")]
        NWI,
        [Description("Norton Bridge")]
        NTB,
        [Description("Norwich")]
        NRW,
        [Description("Norwood Junction")]
        NWD,
        [Description("Nottingham")]
        NOT,
        [Description("Nuneaton")]
        NUN,
        [Description("Nunhead")]
        NHD,
        [Description("Nunthorpe")]
        NNT,
        [Description("Nutbourne")]
        NUT,
        [Description("Nutfield")]
        NUF,
        [Description("Oakengates")]
        OKN,
        [Description("Oakham")]
        OKM,
        [Description("Oakleigh Park")]
        OKL,
        [Description("Oban")]
        OBN,
        [Description("Ockendon")]
        OCK,
        [Description("Ockley")]
        OLY,
        [Description("Okehampton")]
        OKE,
        [Description("Old Hill")]
        OHL,
        [Description("Old Roan")]
        ORN,
        [Description("Old Street")]
        OLD,
        [Description("Oldfield Park")]
        OLF,
        [Description("Olton")]
        OLT,
        [Description("Ore")]
        ORE,
        [Description("Ormskirk")]
        OMS,
        [Description("Orpington")]
        ORP,
        [Description("Orrell")]
        ORR,
        [Description("Orrell Park")]
        OPK,
        [Description("Otford")]
        OTF,
        [Description("Oulton Broad North")]
        OUN,
        [Description("Oulton Broad South")]
        OUS,
        [Description("Outwood")]
        OUT,
        [Description("Overpool")]
        OVE,
        [Description("Overton")]
        OVR,
        [Description("Oxenholme Lake District")]
        OXN,
        [Description("Oxford")]
        OXF,
        [Description("Oxford Parkway")]
        OXP,
        [Description("Oxshott")]
        OXS,
        [Description("Oxted")]
        OXT,
        [Description("Paddock Wood")]
        PDW,
        [Description("Padgate")]
        PDG,
        [Description("Paignton")]
        PGN,
        [Description("Paisley Canal")]
        PCN,
        [Description("Paisley Gilmour Street")]
        PYG,
        [Description("Paisley St James")]
        PYJ,
        [Description("Palmers Green")]
        PAL,
        [Description("Pangbourne")]
        PAN,
        [Description("Pannal")]
        PNL,
        [Description("Pantyffynnon")]
        PTF,
        [Description("Par")]
        PAR,
        [Description("Parbold")]
        PBL,
        [Description("Park Street")]
        PKT,
        [Description("Parkstone (Dorset)")]
        PKS,
        [Description("Parson Street")]
        PSN,
        [Description("Partick")]
        PTK,
        [Description("Parton")]
        PRN,
        [Description("Patchway")]
        PWY,
        [Description("Patricroft")]
        PAT,
        [Description("Patterton")]
        PTT,
        [Description("Peartree")]
        PEA,
        [Description("Peckham Rye")]
        PMR,
        [Description("Pegswood")]
        PEG,
        [Description("Pemberton")]
        PEM,
        [Description("Pembrey & Burry Port")]
        PBY,
        [Description("Pembroke")]
        PMB,
        [Description("Pembroke Dock")]
        PMD,
        [Description("Penally")]
        PNA,
        [Description("Penarth")]
        PEN,
        [Description("Pencoed")]
        PCD,
        [Description("Pengam")]
        PGM,
        [Description("Penge East")]
        PNE,
        [Description("Penge West")]
        PNW,
        [Description("Penhelig")]
        PHG,
        [Description("Penistone")]
        PNS,
        [Description("Penkridge")]
        PKG,
        [Description("Penmaenmawr")]
        PMW,
        [Description("Penmere")]
        PNM,
        [Description("Penrhiwceiber")]
        PER,
        [Description("Penrhyndeudraeth")]
        PRH,
        [Description("Penrith (North Lakes)")]
        PNR,
        [Description("Penryn (Cornwall)")]
        PYN,
        [Description("Pensarn (Gwynedd)")]
        PES,
        [Description("Penshurst")]
        PHR,
        [Description("Pentre-Bach")]
        PTB,
        [Description("Pen-y-Bont")]
        PNY,
        [Description("Penychain")]
        PNC,
        [Description("Penyffordd")]
        PNF,
        [Description("Penzance")]
        PNZ,
        [Description("Perranwell")]
        PRW,
        [Description("Perry Barr")]
        PRY,
        [Description("Pershore")]
        PSH,
        [Description("Perth")]
        PTH,
        [Description("Peterborough")]
        PBO,
        [Description("Petersfield")]
        PTR,
        [Description("Petts Wood")]
        PET,
        [Description("Pevensey & Westham")]
        PEV,
        [Description("Pevensey Bay")]
        PEB,
        [Description("Pewsey")]
        PEW,
        [Description("Pilning")]
        PIL,
        [Description("Pinhoe")]
        PIN,
        [Description("Pitlochry")]
        PIT,
        [Description("Pitsea")]
        PSE,
        [Description("Pleasington")]
        PLS,
        [Description("Plockton")]
        PLK,
        [Description("Pluckley")]
        PLC,
        [Description("Plumley")]
        PLM,
        [Description("Plumpton")]
        PMP,
        [Description("Plumstead")]
        PLU,
        [Description("Plymouth")]
        PLY,
        [Description("Pokesdown")]
        POK,
        [Description("Polegate")]
        PLG,
        [Description("Polesworth")]
        PSW,
        [Description("Pollokshaws East")]
        PWE,
        [Description("Pollokshaws West")]
        PWW,
        [Description("Pollokshields East")]
        PLE,
        [Description("Pollokshields West")]
        PLW,
        [Description("Polmont")]
        PMT,
        [Description("Polsloe Bridge")]
        POL,
        [Description("Ponders End")]
        PON,
        [Description("Pontarddulais")]
        PTD,
        [Description("Pontefract Baghill")]
        PFR,
        [Description("Pontefract Monkhill")]
        PFM,
        [Description("Pontefract Tanshelf")]
        POT,
        [Description("Pontlottyn")]
        PLT,
        [Description("Pontyclun")]
        PYC,
        [Description("Pont-y-Pant")]
        PYP,
        [Description("Pontypool & New Inn")]
        PPL,
        [Description("Pontypridd")]
        PPD,
        [Description("Poole")]
        POO,
        [Description("Poppleton")]
        POP,
        [Description("Port Glasgow")]
        PTG,
        [Description("Port Sunlight")]
        PSL,
        [Description("Port Talbot Parkway")]
        PTA,
        [Description("Portchester")]
        PTC,
        [Description("Porth")]
        POR,
        [Description("Porthmadog")]
        PTM,
        [Description("Portlethen")]
        PLN,
        [Description("Portslade")]
        PLD,
        [Description("Portsmouth & Southsea")]
        PMS,
        [Description("Portsmouth Arms")]
        PMA,
        [Description("Portsmouth Harbour")]
        PMH,
        [Description("Possilpark & Parkhouse")]
        PPK,
        [Description("Potters Bar")]
        PBR,
        [Description("Poulton-le-Fylde")]
        PFY,
        [Description("Poynton")]
        PYT,
        [Description("Prees")]
        PRS,
        [Description("Prescot")]
        PSC,
        [Description("Prestatyn")]
        PRT,
        [Description("Prestbury")]
        PRB,
        [Description("Preston (Lancs)")]
        PRE,
        [Description("Preston Park")]
        PRP,
        [Description("Prestonpans")]
        PST,
        [Description("Prestwick International Airport")]
        PRA,
        [Description("Prestwick Town")]
        PTW,
        [Description("Priesthill & Darnley")]
        PTL,
        [Description("Princes Risborough")]
        PRR,
        [Description("Prittlewell")]
        PRL,
        [Description("Prudhoe")]
        PRU,
        [Description("Pulborough")]
        PUL,
        [Description("Purfleet")]
        PFL,
        [Description("Purley")]
        PUR,
        [Description("Purley Oaks")]
        PUO,
        [Description("Putney")]
        PUT,
        [Description("Pwllheli")]
        PWL,
        [Description("Pye Corner")]
        PYE,
        [Description("Pyle")]
        PYL,
        [Description("Quakers Yard")]
        QYD,
        [Description("Queenborough")]
        QBR,
        [Description("Queens Park (Glasgow)")]
        QPK,
        [Description("Queens Park (London)")]
        QPW,
        [Description("Queens Road (Peckham)")]
        QRP,
        [Description("Queenstown Road (Battersea)")]
        QRB,
        [Description("Quintrell Downs")]
        QUI,
        [Description("Radcliffe-on-Trent")]
        RDF,
        [Description("Radlett")]
        RDT,
        [Description("Radley")]
        RAD,
        [Description("Radyr")]
        RDR,
        [Description("Rainford")]
        RNF,
        [Description("Rainham (Essex)")]
        RNM,
        [Description("Rainham (Kent)")]
        RAI,
        [Description("Rainhill")]
        RNH,
        [Description("Ramsgate")]
        RAM,
        [Description("Ramsgreave & Wilpshire")]
        RGW,
        [Description("Rannoch")]
        RAN,
        [Description("Rauceby")]
        RAU,
        [Description("Ravenglass for Eskdale")]
        RAV,
        [Description("Ravensbourne")]
        RVB,
        [Description("Ravensthorpe")]
        RVN,
        [Description("Rawcliffe")]
        RWC,
        [Description("Rayleigh")]
        RLG,
        [Description("Raynes Park")]
        RAY,
        [Description("Reading")]
        RDG,
        [Description("Reading West")]
        RDW,
        [Description("Rectory Road")]
        REC,
        [Description("Redbridge")]
        RDB,
        [Description("Redcar British Steel")]
        RBS,
        [Description("Redcar Central")]
        RCC,
        [Description("Redcar East")]
        RCE,
        [Description("Reddish North")]
        RDN,
        [Description("Reddish South")]
        RDS,
        [Description("Redditch")]
        RDC,
        [Description("Redhill")]
        RDH,
        [Description("Redland")]
        RDA,
        [Description("Redruth")]
        RED,
        [Description("Reedham (Norfolk)")]
        REE,
        [Description("Reedham (Surrey)")]
        RHM,
        [Description("Reigate")]
        REI,
        [Description("Renton")]
        RTN,
        [Description("Retford")]
        RET,
        [Description("Rhiwbina")]
        RHI,
        [Description("Rhoose Cardiff International Airport")]
        RIA,
        [Description("Rhosneigr")]
        RHO,
        [Description("Rhyl")]
        RHL,
        [Description("Rhymney")]
        RHY,
        [Description("Ribblehead")]
        RHD,
        [Description("Rice Lane")]
        RIL,
        [Description("Richmond (London)")]
        RMD,
        [Description("Rickmansworth")]
        RIC,
        [Description("Riddlesdown")]
        RDD,
        [Description("Ridgmont")]
        RID,
        [Description("Riding Mill")]
        RDM,
        [Description("Risca & Pontymister")]
        RCA,
        [Description("Rishton")]
        RIS,
        [Description("Robertsbridge")]
        RBR,
        [Description("Roby")]
        ROB,
        [Description("Rochdale")]
        RCD,
        [Description("Roche")]
        ROC,
        [Description("Rochester")]
        RTR,
        [Description("Rochford")]
        RFD,
        [Description("Rock Ferry")]
        RFY,
        [Description("Rogart")]
        ROG,
        [Description("Rogerstone")]
        ROR,
        [Description("Rolleston")]
        ROL,
        [Description("Roman Bridge")]
        RMB,
        [Description("Romford")]
        RMF,
        [Description("Romiley")]
        RML,
        [Description("Romsey")]
        ROM,
        [Description("Roose")]
        ROO,
        [Description("Rose Grove")]
        RSG,
        [Description("Rose Hill Marple")]
        RSH,
        [Description("Rosyth")]
        ROS,
        [Description("Rotherham Central")]
        RMC,
        [Description("Rotherhithe")]
        ROE,
        [Description("Roughton Road")]
        RNR,
        [Description("Rowlands Castle")]
        RLN,
        [Description("Rowley Regis")]
        ROW,
        [Description("Roy Bridge")]
        RYB,
        [Description("Roydon")]
        RYN,
        [Description("Royston")]
        RYS,
        [Description("Ruabon")]
        RUA,
        [Description("Rufford")]
        RUF,
        [Description("Rugby")]
        RUG,
        [Description("Rugeley Town")]
        RGT,
        [Description("Rugeley Trent Valley")]
        RGL,
        [Description("Runcorn")]
        RUN,
        [Description("Runcorn East")]
        RUE,
        [Description("Ruskington")]
        RKT,
        [Description("Ruswarp")]
        RUS,
        [Description("Rutherglen")]
        RUT,
        [Description("Ryde Esplanade")]
        RYD,
        [Description("Ryde Pier Head")]
        RYP,
        [Description("Ryde St Johns Road")]
        RYR,
        [Description("Ryder Brow")]
        RRB,
        [Description("Rye (Sussex)")]
        RYE,
        [Description("Rye House")]
        RYH,
        [Description("Salford Central")]
        SFD,
        [Description("Salford Crescent")]
        SLD,
        [Description("Salfords (Surrey)")]
        SAF,
        [Description("Salhouse")]
        SAH,
        [Description("Salisbury")]
        SAL,
        [Description("Saltaire")]
        SAE,
        [Description("Saltash")]
        STS,
        [Description("Saltburn")]
        SLB,
        [Description("Saltcoats")]
        SLT,
        [Description("Saltmarshe")]
        SAM,
        [Description("Salwick")]
        SLW,
        [Description("Sampford Courtenay")]
        SMC,
        [Description("Sandal & Agbrigg")]
        SNA,
        [Description("Sandbach")]
        SDB,
        [Description("Sanderstead")]
        SNR,
        [Description("Sandhills")]
        SDL,
        [Description("Sandhurst (Berks)")]
        SND,
        [Description("Sandling")]
        SDG,
        [Description("Sandown")]
        SAN,
        [Description("Sandplace")]
        SDP,
        [Description("Sandwell & Dudley")]
        SAD,
        [Description("Sandwich")]
        SDW,
        [Description("Sandy")]
        SDY,
        [Description("Sankey for Penketh")]
        SNK,
        [Description("Sanquhar")]
        SQH,
        [Description("Sarn")]
        SRR,
        [Description("Saundersfoot")]
        SDF,
        [Description("Saunderton")]
        SDR,
        [Description("Sawbridgeworth")]
        SAW,
        [Description("Saxilby")]
        SXY,
        [Description("Saxmundham")]
        SAX,
        [Description("Scarborough")]
        SCA,
        [Description("Scotscalder")]
        SCT,
        [Description("Scotstounhill")]
        SCH,
        [Description("Scunthorpe")]
        SCU,
        [Description("Sea Mills")]
        SML,
        [Description("Seaford (Sussex)")]
        SEF,
        [Description("Seaforth & Litherland")]
        SFL,
        [Description("Seaham")]
        SEA,
        [Description("Seamer")]
        SEM,
        [Description("Seascale")]
        SSC,
        [Description("Seaton Carew")]
        SEC,
        [Description("Seer Green & Jordans")]
        SRG,
        [Description("Selby")]
        SBY,
        [Description("Selhurst")]
        SRS,
        [Description("Sellafield")]
        SEL,
        [Description("Selling")]
        SEG,
        [Description("Selly Oak")]
        SLY,
        [Description("Settle")]
        SET,
        [Description("Seven Kings")]
        SVK,
        [Description("Seven Sisters")]
        SVS,
        [Description("Sevenoaks")]
        SEV,
        [Description("Severn Beach")]
        SVB,
        [Description("Severn Tunnel Junction")]
        STJ,
        [Description("Shadwell")]
        SDE,
        [Description("Shalford (Surrey)")]
        SFR,
        [Description("Shanklin")]
        SHN,
        [Description("Shawfair")]
        SFI,
        [Description("Shawford")]
        SHW,
        [Description("Shawlands")]
        SHL,
        [Description("Sheerness-on-Sea")]
        SSS,
        [Description("Sheffield")]
        SHF,
        [Description("Shelford (Cambs)")]
        SED,
        [Description("Shenfield")]
        SNF,
        [Description("Shenstone")]
        SEN,
        [Description("Shepherd's Bush")]
        SPB,
        [Description("Shepherds Well")]
        SPH,
        [Description("Shepley")]
        SPY,
        [Description("Shepperton")]
        SHP,
        [Description("Shepreth")]
        STH,
        [Description("Sherborne")]
        SHE,
        [Description("Sherburn-in-Elmet")]
        SIE,
        [Description("Sheringham")]
        SHM,
        [Description("Shettleston")]
        SLS,
        [Description("Shieldmuir")]
        SDM,
        [Description("Shifnal")]
        SFN,
        [Description("Shildon")]
        SHD,
        [Description("Shiplake")]
        SHI,
        [Description("Shipley (Yorks)")]
        SHY,
        [Description("Shippea Hill")]
        SPP,
        [Description("Shipton")]
        SIP,
        [Description("Shirebrook")]
        SHB,
        [Description("Shirehampton")]
        SHH,
        [Description("Shireoaks")]
        SRO,
        [Description("Shirley")]
        SRL,
        [Description("Shoeburyness")]
        SRY,
        [Description("Sholing")]
        SHO,
        [Description("Shoreditch High Street")]
        SDC,
        [Description("Shoreham (Kent)")]
        SEH,
        [Description("Shoreham-by-Sea")]
        SSE,
        [Description("Shortlands")]
        SRT,
        [Description("Shotton")]
        SHT,
        [Description("Shotts")]
        SHS,
        [Description("Shrewsbury")]
        SHR,
        [Description("Sidcup")]
        SID,
        [Description("Sileby")]
        SIL,
        [Description("Silecroft")]
        SIC,
        [Description("Silkstone Common")]
        SLK,
        [Description("Silver Street")]
        SLV,
        [Description("Silverdale")]
        SVR,
        [Description("Singer")]
        SIN,
        [Description("Sittingbourne")]
        SIT,
        [Description("Skegness")]
        SKG,
        [Description("Skewen")]
        SKE,
        [Description("Skipton")]
        SKI,
        [Description("Slade Green")]
        SGR,
        [Description("Slaithwaite")]
        SWT,
        [Description("Slateford")]
        SLA,
        [Description("Sleaford")]
        SLR,
        [Description("Sleights")]
        SLH,
        [Description("Slough")]
        SLO,
        [Description("Small Heath")]
        SMA,
        [Description("Smallbrook Junction")]
        SAB,
        [Description("Smethwick Galton Bridge")]
        SGB,
        [Description("Smethwick Rolfe Street")]
        SMR,
        [Description("Smithy Bridge")]
        SMB,
        [Description("Snaith")]
        SNI,
        [Description("Snodland")]
        SDA,
        [Description("Snowdown")]
        SWO,
        [Description("Sole Street")]
        SOR,
        [Description("Solihull")]
        SOL,
        [Description("Somerleyton")]
        SYT,
        [Description("South Acton")]
        SAT,
        [Description("South Bank")]
        SBK,
        [Description("South Bermondsey")]
        SBM,
        [Description("South Croydon")]
        SCY,
        [Description("South Elmsall")]
        SES,
        [Description("South Greenford")]
        SGN,
        [Description("South Gyle")]
        SGL,
        [Description("South Hampstead")]
        SOH,
        [Description("South Kenton")]
        SOK,
        [Description("South Merton")]
        SMO,
        [Description("South Milford")]
        SOM,
        [Description("South Ruislip")]
        SRU,
        [Description("South Tottenham")]
        STO,
        [Description("South Wigston")]
        SWS,
        [Description("South Woodham Ferrers")]
        SOF,
        [Description("Southall")]
        STL,
        [Description("Southampton Airport Parkway")]
        SOA,
        [Description("Southampton Central")]
        SOU,
        [Description("Southbourne")]
        SOB,
        [Description("Southbury")]
        SBU,
        [Description("Southease")]
        SEE,
        [Description("Southend Airport")]
        SIA,
        [Description("Southend Central")]
        SOC,
        [Description("Southend East")]
        SOE,
        [Description("Southend Victoria")]
        SOV,
        [Description("Southminster")]
        SMN,
        [Description("Southport")]
        SOP,
        [Description("Southwick")]
        SWK,
        [Description("Sowerby Bridge")]
        SOW,
        [Description("Spalding")]
        SPA,
        [Description("Spean Bridge")]
        SBR,
        [Description("Spital")]
        SPI,
        [Description("Spondon")]
        SPO,
        [Description("Spooner Row")]
        SPN,
        [Description("Spring Road")]
        SRI,
        [Description("Springburn")]
        SPR,
        [Description("Springfield")]
        SPF,
        [Description("Squires Gate")]
        SQU,
        [Description("St Albans Abbey")]
        SAA,
        [Description("St Albans City")]
        SAC,
        [Description("St Andrews Road")]
        SAR,
        [Description("St Annes-on-Sea")]
        SAS,
        [Description("St Austell")]
        SAU,
        [Description("St Bees")]
        SBS,
        [Description("St Budeaux Ferry Road")]
        SBF,
        [Description("St Budeaux Victoria Road")]
        SBV,
        [Description("St Columb Road")]
        SCR,
        [Description("St Denys")]
        SDN,
        [Description("St Erth")]
        SER,
        [Description("St Germans")]
        SGM,
        [Description("St Helens Central")]
        SNH,
        [Description("St Helens Junction")]
        SHJ,
        [Description("St Helier (Surrey)")]
        SIH,
        [Description("St Ives (Cornwall)")]
        SIV,
        [Description("St James Park (Exeter)")]
        SJP,
        [Description("St James Street (Walthamstow)")]
        SJS,
        [Description("St Johns (London)")]
        SAJ,
        [Description("St Keyne Wishing Well Halt")]
        SKN,
        [Description("St Leonards Warrior Square")]
        SLQ,
        [Description("St Margarets (Herts)")]
        SMT,
        [Description("St Margarets (London)")]
        SMG,
        [Description("St Mary Cray")]
        SMY,
        [Description("St Michaels")]
        STM,
        [Description("St Neots")]
        SNO,
        [Description("Stafford")]
        STA,
        [Description("Staines")]
        SNS,
        [Description("Stallingborough")]
        SLL,
        [Description("Stalybridge")]
        SYB,
        [Description("Stamford (Lincs)")]
        SMD,
        [Description("Stamford Hill")]
        SMH,
        [Description("Stanford-le-Hope")]
        SFO,
        [Description("Stanlow & Thornton")]
        SNT,
        [Description("Stansted Airport")]
        SSD,
        [Description("Stansted Mountfitchet")]
        SST,
        [Description("Staplehurst")]
        SPU,
        [Description("Stapleton Road")]
        SRD,
        [Description("Starbeck")]
        SBE,
        [Description("Starcross")]
        SCS,
        [Description("Staveley (Cumbria)")]
        SVL,
        [Description("Stechford")]
        SCF,
        [Description("Steeton & Silsden")]
        SON,
        [Description("Stepps")]
        SPS,
        [Description("Stevenage")]
        SVG,
        [Description("Stevenston")]
        STV,
        [Description("Stewartby")]
        SWR,
        [Description("Stewarton")]
        STT,
        [Description("Stirling")]
        STG,
        [Description("Stockport")]
        SPT,
        [Description("Stocksfield")]
        SKS,
        [Description("Stocksmoor")]
        SSM,
        [Description("Stockton")]
        STK,
        [Description("Stoke Mandeville")]
        SKM,
        [Description("Stoke Newington")]
        SKW,
        [Description("Stoke-on-Trent")]
        SOT,
        [Description("Stone (Staffs)")]
        SNE,
        [Description("Stone Crossing")]
        SCG,
        [Description("Stonebridge Park")]
        SBP,
        [Description("Stonegate")]
        SOG,
        [Description("Stonehaven")]
        STN,
        [Description("Stonehouse")]
        SHU,
        [Description("Stoneleigh")]
        SNL,
        [Description("Stourbridge Junction")]
        SBJ,
        [Description("Stourbridge Town")]
        SBT,
        [Description("Stow")]
        SOI,
        [Description("Stowmarket")]
        SMK,
        [Description("Stranraer")]
        STR,
        [Description("Stratford (London)")]
        SRA,
        [Description("Stratford International")]
        SFA,
        [Description("Stratford-upon-Avon")]
        SAV,
        [Description("Stratford-upon-Avon Parkway")]
        STY,
        [Description("Strathcarron")]
        STC,
        [Description("Strawberry Hill")]
        STW,
        [Description("Streatham (Greater London)")]
        STE,
        [Description("Streatham Common")]
        SRC,
        [Description("Streatham Hill")]
        SRH,
        [Description("Streethouse")]
        SHC,
        [Description("Strines")]
        SRN,
        [Description("Stromeferry")]
        STF,
        [Description("Strood (Kent)")]
        SOO,
        [Description("Stroud (Gloucs)")]
        STD,
        [Description("Sturry")]
        STU,
        [Description("Styal")]
        SYA,
        [Description("Sudbury & Harrow Road")]
        SUD,
        [Description("Sudbury (Suffolk)")]
        SUY,
        [Description("Sudbury Hill Harrow")]
        SDH,
        [Description("Sugar Loaf")]
        SUG,
        [Description("Summerston")]
        SUM,
        [Description("Sunbury")]
        SUU,
        [Description("Sunderland")]
        SUN,
        [Description("Sundridge Park")]
        SUP,
        [Description("Sunningdale")]
        SNG,
        [Description("Sunnymeads")]
        SNY,
        [Description("Surbiton")]
        SUR,
        [Description("Surrey Quays")]
        SQE,
        [Description("Sutton (Surrey)")]
        SUO,
        [Description("Sutton Coldfield")]
        SUT,
        [Description("Sutton Common")]
        SUC,
        [Description("Sutton Parkway")]
        SPK,
        [Description("Swale")]
        SWL,
        [Description("Swanley")]
        SAY,
        [Description("Swanscombe")]
        SWM,
        [Description("Swansea")]
        SWA,
        [Description("Swanwick")]
        SNW,
        [Description("Sway")]
        SWY,
        [Description("Swaythling")]
        SWG,
        [Description("Swinderby")]
        SWD,
        [Description("Swindon (Wilts)")]
        SWI,
        [Description("Swineshead")]
        SWE,
        [Description("Swinton (Manchester)")]
        SNN,
        [Description("Swinton (South Yorks)")]
        SWN,
        [Description("Sydenham (London)")]
        SYD,
        [Description("Sydenham Hill")]
        SYH,
        [Description("Syon Lane")]
        SYL,
        [Description("Syston")]
        SYS,
        [Description("Tackley")]
        TAC,
        [Description("Tadworth")]
        TAD,
        [Description("Taffs Well")]
        TAF,
        [Description("Tain")]
        TAI,
        [Description("Talsarnau")]
        TAL,
        [Description("Talybont")]
        TLB,
        [Description("Tal-y-Cafn")]
        TLC,
        [Description("Tame Bridge Parkway")]
        TAB,
        [Description("Tamworth")]
        TAM,
        [Description("Taplow")]
        TAP,
        [Description("Tattenham Corner")]
        TAT,
        [Description("Taunton")]
        TAU,
        [Description("Taynuilt")]
        TAY,
        [Description("Teddington")]
        TED,
        [Description("Tees-side Airport")]
        TEA,
        [Description("Teignmouth")]
        TGM,
        [Description("Telford Central")]
        TFC,
        [Description("Templecombe")]
        TMC,
        [Description("Tenby")]
        TEN,
        [Description("Teynham")]
        TEY,
        [Description("Thames Ditton")]
        THD,
        [Description("Thatcham")]
        THA,
        [Description("Thatto Heath")]
        THH,
        [Description("The Hawthorns")]
        THW,
        [Description("The Lakes (Warks)")]
        TLK,
        [Description("Theale")]
        THE,
        [Description("Theobalds Grove")]
        TEO,
        [Description("Thetford")]
        TTF,
        [Description("Thirsk")]
        THI,
        [Description("Thornaby")]
        TBY,
        [Description("Thorne North")]
        TNN,
        [Description("Thorne South")]
        TNS,
        [Description("Thornford")]
        THO,
        [Description("Thornliebank")]
        THB,
        [Description("Thornton Abbey")]
        TNA,
        [Description("Thornton Heath")]
        TTH,
        [Description("Thorntonhall")]
        THT,
        [Description("Thorpe Bay")]
        TPB,
        [Description("Thorpe Culvert")]
        TPC,
        [Description("Thorpe-le-Soken")]
        TLS,
        [Description("Three Bridges")]
        TBD,
        [Description("Three Oaks")]
        TOK,
        [Description("Thurgarton")]
        THU,
        [Description("Thurnscoe")]
        THC,
        [Description("Thurso")]
        THS,
        [Description("Thurston")]
        TRS,
        [Description("Tilbury Town")]
        TIL,
        [Description("Tile Hill")]
        THL,
        [Description("Tilehurst")]
        TLH,
        [Description("Tipton")]
        TIP,
        [Description("Tir-Phil")]
        TIR,
        [Description("Tisbury")]
        TIS,
        [Description("Tiverton Parkway")]
        TVP,
        [Description("Todmorden")]
        TOD,
        [Description("Tolworth")]
        TOL,
        [Description("Ton Pentre")]
        TPN,
        [Description("Tonbridge")]
        TON,
        [Description("Tondu")]
        TDU,
        [Description("Tonfanau")]
        TNF,
        [Description("Tonypandy")]
        TNP,
        [Description("Tooting")]
        TOO,
        [Description("Topsham")]
        TOP,
        [Description("Torquay")]
        TQY,
        [Description("Torre")]
        TRR,
        [Description("Totnes")]
        TOT,
        [Description("Tottenham Hale")]
        TOM,
        [Description("Totton")]
        TTN,
        [Description("Town Green")]
        TWN,
        [Description("Trafford Park")]
        TRA,
        [Description("Trefforest")]
        TRF,
        [Description("Trefforest Estate")]
        TRE,
        [Description("Trehafod")]
        TRH,
        [Description("Treherbert")]
        TRB,
        [Description("Treorchy")]
        TRY,
        [Description("Trimley")]
        TRM,
        [Description("Tring")]
        TRI,
        [Description("Troed-y-rhiw")]
        TRD,
        [Description("Troon")]
        TRN,
        [Description("Trowbridge")]
        TRO,
        [Description("Truro")]
        TRU,
        [Description("Tulloch")]
        TUL,
        [Description("Tulse Hill")]
        TUH,
        [Description("Tunbridge Wells")]
        TBW,
        [Description("Turkey Street")]
        TUR,
        [Description("Tutbury & Hatton")]
        TUT,
        [Description("Tweedbank")]
        TWB,
        [Description("Twickenham")]
        TWI,
        [Description("Twyford")]
        TWY,
        [Description("Ty Croes")]
        TYC,
        [Description("Ty Glas")]
        TGS,
        [Description("Tygwyn")]
        TYG,
        [Description("Tyndrum Lower")]
        TYL,
        [Description("Tyseley")]
        TYS,
        [Description("Tywyn")]
        TYW,
        [Description("Uckfield")]
        UCK,
        [Description("Uddingston")]
        UDD,
        [Description("Ulceby")]
        ULC,
        [Description("Ulleskelf")]
        ULL,
        [Description("Ulverston")]
        ULV,
        [Description("Umberleigh")]
        UMB,
        [Description("University (Birmingham)")]
        UNI,
        [Description("Uphall")]
        UHA,
        [Description("Upholland")]
        UPL,
        [Description("Upminster")]
        UPM,
        [Description("Upper Halliford")]
        UPH,
        [Description("Upper Holloway")]
        UHL,
        [Description("Upper Tyndrum")]
        UTY,
        [Description("Upper Warlingham")]
        UWL,
        [Description("Upton (Merseyside)")]
        UPT,
        [Description("Upwey")]
        UPW,
        [Description("Urmston")]
        URM,
        [Description("Uttoxeter")]
        UTT,
        [Description("Valley")]
        VAL,
        [Description("Vauxhall")]
        VXH,
        [Description("Virginia Water")]
        VIR,
        [Description("Waddon")]
        WDO,
        [Description("Wadhurst")]
        WAD,
        [Description("Wainfleet")]
        WFL,
        [Description("Wakefield Kirkgate")]
        WKK,
        [Description("Wakefield Westgate")]
        WKF,
        [Description("Walkden")]
        WKD,
        [Description("Wallasey Grove Road")]
        WLG,
        [Description("Wallasey Village")]
        WLV,
        [Description("Wallington")]
        WLT,
        [Description("Wallyford")]
        WAF,
        [Description("Walmer")]
        WAM,
        [Description("Walsall")]
        WSL,
        [Description("Walsden")]
        WDN,
        [Description("Waltham Cross")]
        WLC,
        [Description("Walthamstow Central")]
        WHC,
        [Description("Walthamstow Queen's Road")]
        WMW,
        [Description("Walton (Merseyside)")]
        WAO,
        [Description("Walton-on-Thames")]
        WAL,
        [Description("Walton-on-the-Naze")]
        WON,
        [Description("Wanborough")]
        WAN,
        [Description("Wandsworth Common")]
        WSW,
        [Description("Wandsworth Road")]
        WWR,
        [Description("Wandsworth Town")]
        WNT,
        [Description("Wanstead Park")]
        WNP,
        [Description("Wapping")]
        WPE,
        [Description("Warblington")]
        WBL,
        [Description("Ware (Herts)")]
        WAR,
        [Description("Wareham (Dorset)")]
        WRM,
        [Description("Wargrave")]
        WGV,
        [Description("Warminster")]
        WMN,
        [Description("Warnham")]
        WNH,
        [Description("Warrington Bank Quay")]
        WBQ,
        [Description("Warrington Central")]
        WAC,
        [Description("Warwick")]
        WRW,
        [Description("Warwick Parkway")]
        WRP,
        [Description("Water Orton")]
        WTO,
        [Description("Waterbeach")]
        WBC,
        [Description("Wateringbury")]
        WTR,
        [Description("Waterloo (Merseyside)")]
        WLO,
        [Description("Watford High Street")]
        WFH,
        [Description("Watford Junction")]
        WFJ,
        [Description("Watford North")]
        WFN,
        [Description("Watlington")]
        WTG,
        [Description("Watton-at-Stone")]
        WAS,
        [Description("Waun-Gron Park")]
        WNG,
        [Description("Wavertree Technology Park")]
        WAV,
        [Description("Wedgwood")]
        WED,
        [Description("Weeley")]
        WEE,
        [Description("Weeton")]
        WET,
        [Description("Welham Green")]
        WMG,
        [Description("Welling")]
        WLI,
        [Description("Wellingborough")]
        WEL,
        [Description("Wellington (Shropshire)")]
        WLN,
        [Description("Welshpool")]
        WLP,
        [Description("Welwyn Garden City")]
        WGC,
        [Description("Welwyn North")]
        WLW,
        [Description("Wem")]
        WEM,
        [Description("Wembley Central")]
        WMB,
        [Description("Wembley Stadium")]
        WCX,
        [Description("Wemyss Bay")]
        WMS,
        [Description("Wendover")]
        WND,
        [Description("Wennington")]
        WNN,
        [Description("West Allerton")]
        WSA,
        [Description("West Brompton")]
        WBP,
        [Description("West Byfleet")]
        WBY,
        [Description("West Calder")]
        WCL,
        [Description("West Croydon")]
        WCY,
        [Description("West Drayton")]
        WDT,
        [Description("West Dulwich")]
        WDU,
        [Description("West Ealing")]
        WEA,
        [Description("West Ham")]
        WEH,
        [Description("West Hampstead")]
        WHD,
        [Description("West Hampstead Thameslink")]
        WHP,
        [Description("West Horndon")]
        WHR,
        [Description("West Kilbride")]
        WKB,
        [Description("West Kirby")]
        WKI,
        [Description("West Malling")]
        WMA,
        [Description("West Norwood")]
        WNW,
        [Description("West Ruislip")]
        WRU,
        [Description("West Runton")]
        WRN,
        [Description("West St Leonards")]
        WLD,
        [Description("West Sutton")]
        WSU,
        [Description("West Wickham")]
        WWI,
        [Description("West Worthing")]
        WWO,
        [Description("Westbury (Wilts)")]
        WSB,
        [Description("Westcliff")]
        WCF,
        [Description("Westcombe Park")]
        WCB,
        [Description("Westenhanger")]
        WHA,
        [Description("Wester Hailes")]
        WTA,
        [Description("Westerfield")]
        WFI,
        [Description("Westerton")]
        WES,
        [Description("Westgate-on-Sea")]
        WGA,
        [Description("Westhoughton")]
        WHG,
        [Description("Weston Milton")]
        WNM,
        [Description("Weston-super-Mare")]
        WSM,
        [Description("Wetheral")]
        WRL,
        [Description("Weybridge")]
        WYB,
        [Description("Weymouth")]
        WEY,
        [Description("Whaley Bridge")]
        WBR,
        [Description("Whalley (Lancs)")]
        WHE,
        [Description("Whatstandwell")]
        WTS,
        [Description("Whifflet")]
        WFF,
        [Description("Whimple")]
        WHM,
        [Description("Whinhill")]
        WNL,
        [Description("Whiston")]
        WHN,
        [Description("Whitby")]
        WTB,
        [Description("Whitchurch (Cardiff)")]
        WHT,
        [Description("Whitchurch (Hants)")]
        WCH,
        [Description("Whitchurch (Shropshire)")]
        WTC,
        [Description("White Hart Lane")]
        WHL,
        [Description("White Notley")]
        WNY,
        [Description("Whitechapel")]
        ZLW,
        [Description("Whitecraigs")]
        WCR,
        [Description("Whitehaven")]
        WTH,
        [Description("Whitland")]
        WTL,
        [Description("Whitley Bridge")]
        WBD,
        [Description("Whitlocks End")]
        WTE,
        [Description("Whitstable")]
        WHI,
        [Description("Whittlesea")]
        WLE,
        [Description("Whittlesford Parkway")]
        WLF,
        [Description("Whitton (London)")]
        WTN,
        [Description("Whitwell (Derbyshire)")]
        WWL,
        [Description("Whyteleafe")]
        WHY,
        [Description("Whyteleafe South")]
        WHS,
        [Description("Wick")]
        WCK,
        [Description("Wickford")]
        WIC,
        [Description("Wickham Market")]
        WCM,
        [Description("Widdrington")]
        WDD,
        [Description("Widnes")]
        WID,
        [Description("Widney Manor")]
        WMR,
        [Description("Wigan North Western")]
        WGN,
        [Description("Wigan Wallgate")]
        WGW,
        [Description("Wigton")]
        WGT,
        [Description("Wildmill")]
        WMI,
        [Description("Willesden Junction")]
        WIJ,
        [Description("Williamwood")]
        WLM,
        [Description("Willington")]
        WIL,
        [Description("Wilmcote")]
        WMC,
        [Description("Wilmslow")]
        WML,
        [Description("Wilnecote (Staffs)")]
        WNE,
        [Description("Wimbledon")]
        WIM,
        [Description("Wimbledon Chase")]
        WBO,
        [Description("Winchelsea")]
        WSE,
        [Description("Winchester")]
        WIN,
        [Description("Winchfield")]
        WNF,
        [Description("Winchmore Hill")]
        WIH,
        [Description("Windermere")]
        WDM,
        [Description("Windsor & Eton Central")]
        WNC,
        [Description("Windsor & Eton Riverside")]
        WNR,
        [Description("Winnersh")]
        WNS,
        [Description("Winnersh Triangle")]
        WTI,
        [Description("Winsford")]
        WSF,
        [Description("Wishaw")]
        WSH,
        [Description("Witham")]
        WTM,
        [Description("Witley")]
        WTY,
        [Description("Witton (West Midlands)")]
        WTT,
        [Description("Wivelsfield")]
        WVF,
        [Description("Wivenhoe")]
        WIV,
        [Description("Woburn Sands")]
        WOB,
        [Description("Woking")]
        WOK,
        [Description("Wokingham")]
        WKM,
        [Description("Woldingham")]
        WOH,
        [Description("Wolverhampton")]
        WVH,
        [Description("Wolverton")]
        WOL,
        [Description("Wombwell")]
        WOM,
        [Description("Wood End")]
        WDE,
        [Description("Wood Street")]
        WST,
        [Description("Woodbridge")]
        WDB,
        [Description("Woodgrange Park")]
        WGR,
        [Description("Woodhall")]
        WDL,
        [Description("Woodhouse")]
        WDH,
        [Description("Woodlesford")]
        WDS,
        [Description("Woodley")]
        WLY,
        [Description("Woodmansterne")]
        WME,
        [Description("Woodsmoor")]
        WSR,
        [Description("Wool")]
        WOO,
        [Description("Woolston")]
        WLS,
        [Description("Woolwich Arsenal")]
        WWA,
        [Description("Woolwich Dockyard")]
        WWD,
        [Description("Wootton Wawen")]
        WWW,
        [Description("Worcester Foregate Street")]
        WOF,
        [Description("Worcester Park")]
        WCP,
        [Description("Worcester Shrub Hill")]
        WOS,
        [Description("Workington")]
        WKG,
        [Description("Worksop")]
        WRK,
        [Description("Worle")]
        WOR,
        [Description("Worplesdon")]
        WPL,
        [Description("Worstead")]
        WRT,
        [Description("Worthing")]
        WRH,
        [Description("Wrabness")]
        WRB,
        [Description("Wraysbury")]
        WRY,
        [Description("Wrenbury")]
        WRE,
        [Description("Wressle")]
        WRS,
        [Description("Wrexham Central")]
        WXC,
        [Description("Wrexham General")]
        WRX,
        [Description("Wye")]
        WYE,
        [Description("Wylam")]
        WYM,
        [Description("Wylde Green")]
        WYL,
        [Description("Wymondham")]
        WMD,
        [Description("Wythall")]
        WYT,
        [Description("Yalding")]
        YAL,
        [Description("Yardley Wood")]
        YRD,
        [Description("Yarm")]
        YRM,
        [Description("Yate")]
        YAE,
        [Description("Yatton")]
        YAT,
        [Description("Yeoford")]
        YEO,
        [Description("Yeovil Junction")]
        YVJ,
        [Description("Yeovil Pen Mill")]
        YVP,
        [Description("Yetminster")]
        YET,
        [Description("Ynyswen")]
        YNW,
        [Description("Yoker")]
        YOK,
        [Description("York")]
        YRK,
        [Description("Yorton")]
        YRT,
        [Description("Ystrad Mynach")]
        YSM,
        [Description("Ystrad Rhondda")]
        YSR,

    }
}
