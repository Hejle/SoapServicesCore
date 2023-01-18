namespace RestApiCertificateTest
{
    public static class ClaimKeyExtensions
    {
        public static string ToStringFast(this ClaimKey value) => value switch
        {
            ClaimKey.None => nameof(ClaimKey.None),
            ClaimKey.SoegPerson => nameof(ClaimKey.SoegPerson),
            ClaimKey.PersonkortBasis => nameof(ClaimKey.PersonkortBasis),
            ClaimKey.Stamdata => nameof(ClaimKey.Stamdata),
            ClaimKey.FanenRelationer => nameof(ClaimKey.FanenRelationer),
            ClaimKey.RedigerStamdata => nameof(ClaimKey.RedigerStamdata),
            ClaimKey.RedigerYdelseRelation => nameof(ClaimKey.RedigerYdelseRelation),
            ClaimKey.OpretYdelseRelation => nameof(ClaimKey.OpretYdelseRelation),
            ClaimKey.VisYdelseRelation => nameof(ClaimKey.VisYdelseRelation),
            ClaimKey.RedigerBookingRelation => nameof(ClaimKey.RedigerBookingRelation),
            ClaimKey.OpretBookingRelation => nameof(ClaimKey.OpretBookingRelation),
            ClaimKey.VisBookingRelation => nameof(ClaimKey.VisBookingRelation),
            ClaimKey.FanenIndkvartering => nameof(ClaimKey.FanenIndkvartering),
            ClaimKey.FlytInd => nameof(ClaimKey.FlytInd),
            ClaimKey.FlytUd => nameof(ClaimKey.FlytUd),
            ClaimKey.VisAktuelIndkvartering => nameof(ClaimKey.VisAktuelIndkvartering),
            ClaimKey.RedigerAktuelIndkvartering => nameof(ClaimKey.RedigerAktuelIndkvartering),
            ClaimKey.OpretFlyttespaerring => nameof(ClaimKey.OpretFlyttespaerring),
            ClaimKey.OphaevFlyttespaerring => nameof(ClaimKey.OphaevFlyttespaerring),
            ClaimKey.VisPlanlagtFlytning => nameof(ClaimKey.VisPlanlagtFlytning),
            ClaimKey.VisTidligereIndkvartering => nameof(ClaimKey.VisTidligereIndkvartering),
            ClaimKey.VisIndkvarteringHistorik => nameof(ClaimKey.VisIndkvarteringHistorik),
            ClaimKey.FanenModtagefunktioner => nameof(ClaimKey.FanenModtagefunktioner),
            ClaimKey.VisModtagefunktioner => nameof(ClaimKey.VisModtagefunktioner),
            ClaimKey.OpretModtagefunktion => nameof(ClaimKey.OpretModtagefunktion),
            ClaimKey.RedigerModtagefunktion => nameof(ClaimKey.RedigerModtagefunktion),
            ClaimKey.FanenPlanlaegFlytning => nameof(ClaimKey.FanenPlanlaegFlytning),
            ClaimKey.VisVurderingsgrundlag => nameof(ClaimKey.VisVurderingsgrundlag),
            ClaimKey.SaetFlytteklar => nameof(ClaimKey.SaetFlytteklar),
            ClaimKey.SaetIkkeFlytteklar => nameof(ClaimKey.SaetIkkeFlytteklar),
            ClaimKey.OpretPlanlagtFlytning => nameof(ClaimKey.OpretPlanlagtFlytning),
            ClaimKey.RedigerPlanlagtFlytning => nameof(ClaimKey.RedigerPlanlagtFlytning),
            ClaimKey.FanenYdelser => nameof(ClaimKey.FanenYdelser),
            ClaimKey.SaetYdelseStopdato => nameof(ClaimKey.SaetYdelseStopdato),
            ClaimKey.FjernYdelseStopdato => nameof(ClaimKey.FjernYdelseStopdato),
            ClaimKey.OpretManuelUdbetaling => nameof(ClaimKey.OpretManuelUdbetaling),
            ClaimKey.OpretIndividueltBeregningsgrundlag => nameof(ClaimKey.OpretIndividueltBeregningsgrundlag),
            ClaimKey.SletIndividueltBeregningsgrundlag => nameof(ClaimKey.SletIndividueltBeregningsgrundlag),
            ClaimKey.VisOpsparedetillægsydelser => nameof(ClaimKey.VisOpsparedetillægsydelser),
            ClaimKey.SletTillaegsydelse => nameof(ClaimKey.SletTillaegsydelse),
            ClaimKey.VisUdbetalingsspecifikationer => nameof(ClaimKey.VisUdbetalingsspecifikationer),
            ClaimKey.FanenNaturalieydelser => nameof(ClaimKey.FanenNaturalieydelser),
            ClaimKey.VisManuelNaturalieudlevering => nameof(ClaimKey.VisManuelNaturalieudlevering),
            ClaimKey.OpretManuelNaturalieudlevering => nameof(ClaimKey.OpretManuelNaturalieudlevering),
            ClaimKey.VisModtagerNaturalieYdelserPaaVegneAf => nameof(ClaimKey.VisModtagerNaturalieYdelserPaaVegneAf),
            ClaimKey.ListeModtagefunktioner => nameof(ClaimKey.ListeModtagefunktioner),
            ClaimKey.ListeMaaskeFlytteklareFraModtagecenter => nameof(ClaimKey.ListeMaaskeFlytteklareFraModtagecenter),
            ClaimKey.ListeFlytteklarePersoner => nameof(ClaimKey.ListeFlytteklarePersoner),
            ClaimKey.ListeFlytteklarePlanlaegFlytning => nameof(ClaimKey.ListeFlytteklarePlanlaegFlytning),
            ClaimKey.ListePlanlagteIndflytninger => nameof(ClaimKey.ListePlanlagteIndflytninger),
            ClaimKey.ListePlanlagteIndflytningerFlytInd => nameof(ClaimKey.ListePlanlagteIndflytningerFlytInd),
            ClaimKey.ListePlanlagteUdflytninger => nameof(ClaimKey.ListePlanlagteUdflytninger),
            ClaimKey.ListePlanlagteUdflytningerFlytUd => nameof(ClaimKey.ListePlanlagteUdflytningerFlytUd),
            ClaimKey.ListeOverskrednePlanlagteIndflytninger => nameof(ClaimKey.ListeOverskrednePlanlagteIndflytninger),
            ClaimKey.ListeOverskrednePlanlagteIndflytningerFlytInd => nameof(ClaimKey.ListeOverskrednePlanlagteIndflytningerFlytInd),
            ClaimKey.ListeIndflytninger => nameof(ClaimKey.ListeIndflytninger),
            ClaimKey.ListeUdflytninger => nameof(ClaimKey.ListeUdflytninger),
            ClaimKey.ListeIndkvarteredePersoner => nameof(ClaimKey.ListeIndkvarteredePersoner),
            ClaimKey.ListeLedsagedeUledsagedeBoern => nameof(ClaimKey.ListeLedsagedeUledsagedeBoern),
            ClaimKey.ListeFamilielisten => nameof(ClaimKey.ListeFamilielisten),
            ClaimKey.ListePersonerIndskrevetPaaMereEndEtCenter => nameof(ClaimKey.ListePersonerIndskrevetPaaMereEndEtCenter),
            ClaimKey.ListePersonerMedDobbeltIndkvarteringer => nameof(ClaimKey.ListePersonerMedDobbeltIndkvarteringer),
            ClaimKey.ListeUdeblevneFraCenter => nameof(ClaimKey.ListeUdeblevneFraCenter),
            ClaimKey.ListeUdrejstePersoner => nameof(ClaimKey.ListeUdrejstePersoner),
            ClaimKey.ListeKommendeIntegrationer => nameof(ClaimKey.ListeKommendeIntegrationer),
            ClaimKey.ListeOverskredneIntegrationer => nameof(ClaimKey.ListeOverskredneIntegrationer),
            ClaimKey.ListeKapacitetsoversigt => nameof(ClaimKey.ListeKapacitetsoversigt),
            ClaimKey.ListeBelaegningsdoegn => nameof(ClaimKey.ListeBelaegningsdoegn),
            ClaimKey.ListeMaanedsrapportBelaegningsdoegn => nameof(ClaimKey.ListeMaanedsrapportBelaegningsdoegn),
            ClaimKey.ListeAarskorrektionerBelaegningsdoegn => nameof(ClaimKey.ListeAarskorrektionerBelaegningsdoegn),
            ClaimKey.ListeMaanedsrapportModtagefunktioner => nameof(ClaimKey.ListeMaanedsrapportModtagefunktioner),
            ClaimKey.ListeUdbetalingsliste => nameof(ClaimKey.ListeUdbetalingsliste),
            ClaimKey.ListeUdbetalingslisteKvitterOgGem => nameof(ClaimKey.ListeUdbetalingslisteKvitterOgGem),
            ClaimKey.ListeManuelUdbetalingsliste => nameof(ClaimKey.ListeManuelUdbetalingsliste),
            ClaimKey.ListeManuelUdbetalignslisteKvitterOgGem => nameof(ClaimKey.ListeManuelUdbetalignslisteKvitterOgGem),
            ClaimKey.ListeOmposteringsliste => nameof(ClaimKey.ListeOmposteringsliste),
            ClaimKey.ListeNaturalieliste => nameof(ClaimKey.ListeNaturalieliste),
            ClaimKey.ListeNaturalielisteKvitterOgGem => nameof(ClaimKey.ListeNaturalielisteKvitterOgGem),
            ClaimKey.ListeManuelNaturalieliste => nameof(ClaimKey.ListeManuelNaturalieliste),
            ClaimKey.ListeManuelNaturalielisteKvitterOgGem => nameof(ClaimKey.ListeManuelNaturalielisteKvitterOgGem),
            ClaimKey.ListeNaturalieSpecifikation => nameof(ClaimKey.ListeNaturalieSpecifikation),
            ClaimKey.ListeKontraktopfyldelse => nameof(ClaimKey.ListeKontraktopfyldelse),
            ClaimKey.ListeKontraktopfyldelseIndtastKontraktopfyldelseOgGem => nameof(ClaimKey.ListeKontraktopfyldelseIndtastKontraktopfyldelseOgGem),
            ClaimKey.ListeMoentenhedsspecifikation => nameof(ClaimKey.ListeMoentenhedsspecifikation),
            ClaimKey.ListeAaghListe => nameof(ClaimKey.ListeAaghListe),
            ClaimKey.ListeOverPersonerPaaFase => nameof(ClaimKey.ListeOverPersonerPaaFase),
            ClaimKey.RedigerCentermeddelelse => nameof(ClaimKey.RedigerCentermeddelelse),
            ClaimKey.OpretOperatoer => nameof(ClaimKey.OpretOperatoer),
            ClaimKey.RedigerOperatoer => nameof(ClaimKey.RedigerOperatoer),
            ClaimKey.OpretCenter => nameof(ClaimKey.OpretCenter),
            ClaimKey.VisOperatører => nameof(ClaimKey.VisOperatører),
            ClaimKey.VisNedlagteCentre => nameof(ClaimKey.VisNedlagteCentre),
            ClaimKey.GenaktiverNedlagtCenter => nameof(ClaimKey.GenaktiverNedlagtCenter),
            ClaimKey.VisCentre => nameof(ClaimKey.VisCentre),
            ClaimKey.RedigerCenter => nameof(ClaimKey.RedigerCenter),
            ClaimKey.NedlaegCenter => nameof(ClaimKey.NedlaegCenter),
            ClaimKey.OpretIndkvarteringssted => nameof(ClaimKey.OpretIndkvarteringssted),
            ClaimKey.RedigerIndkvarteringssted => nameof(ClaimKey.RedigerIndkvarteringssted),
            ClaimKey.NedlaegIndkvarteringssted => nameof(ClaimKey.NedlaegIndkvarteringssted),
            ClaimKey.VisKontanteYdelser => nameof(ClaimKey.VisKontanteYdelser),
            ClaimKey.OpretKontantydelse => nameof(ClaimKey.OpretKontantydelse),
            ClaimKey.SletKontantydelse => nameof(ClaimKey.SletKontantydelse),
            ClaimKey.VisNaturalieYdelser => nameof(ClaimKey.VisNaturalieYdelser),
            ClaimKey.OpretNaturalieydelse => nameof(ClaimKey.OpretNaturalieydelse),
            ClaimKey.SletNaturalieydelse => nameof(ClaimKey.SletNaturalieydelse),
            ClaimKey.OpretPerson => nameof(ClaimKey.OpretPerson),
            ClaimKey.RedigerVæerdilisteIndflytningsårsager => nameof(ClaimKey.RedigerVæerdilisteIndflytningsårsager),
            ClaimKey.RedigerVæerdilisteUdflytningsårsager => nameof(ClaimKey.RedigerVæerdilisteUdflytningsårsager),
            ClaimKey.RedigerVæerdilisteBookingRelationTyper => nameof(ClaimKey.RedigerVæerdilisteBookingRelationTyper),
            ClaimKey.RedigerVæerdilisteModtagefunktionTyper => nameof(ClaimKey.RedigerVæerdilisteModtagefunktionTyper),
            ClaimKey.RedigerVæerdilisteFlyttespaerringsAarsager => nameof(ClaimKey.RedigerVæerdilisteFlyttespaerringsAarsager),
            ClaimKey.AdgangTilAllePersoner => nameof(ClaimKey.AdgangTilAllePersoner),
            ClaimKey.USForside => nameof(ClaimKey.USForside),
            ClaimKey.CenterForside => nameof(ClaimKey.CenterForside),
            ClaimKey.AdministrationsForside => nameof(ClaimKey.AdministrationsForside),
            ClaimKey.ListeKasseafstemning => nameof(ClaimKey.ListeKasseafstemning),
            ClaimKey.RedigerVæerdilisteModtagekategorier => nameof(ClaimKey.RedigerVæerdilisteModtagekategorier),
            ClaimKey.VisKontraktopfyldelse => nameof(ClaimKey.VisKontraktopfyldelse),
            ClaimKey.RedigerKontraktopfyldelse => nameof(ClaimKey.RedigerKontraktopfyldelse),
            ClaimKey.ListeAvanceret => nameof(ClaimKey.ListeAvanceret),
            ClaimKey.RedigerCenterBruger => nameof(ClaimKey.RedigerCenterBruger),
            ClaimKey.RedigerFaseManuelt => nameof(ClaimKey.RedigerFaseManuelt),
            ClaimKey.KaldFraDrkService => nameof(ClaimKey.KaldFraDrkService),
            ClaimKey.RedigerVæerdilisteBygningstyper => nameof(ClaimKey.RedigerVæerdilisteBygningstyper),
            ClaimKey.RedigerYdelseSatser => nameof(ClaimKey.RedigerYdelseSatser),
            ClaimKey.RedigerNaturalieSatser => nameof(ClaimKey.RedigerNaturalieSatser),
            ClaimKey.RedigerStamdataAagh => nameof(ClaimKey.RedigerStamdataAagh),
            ClaimKey.RedigerStamdataLedsagetType => nameof(ClaimKey.RedigerStamdataLedsagetType),
            ClaimKey.ListeVoksenToejpakker => nameof(ClaimKey.ListeVoksenToejpakker),
            ClaimKey.ListeIndividueltBeregningsgrundlag => nameof(ClaimKey.ListeIndividueltBeregningsgrundlag),
            ClaimKey.ListeOpsparedeTillaegsydelser => nameof(ClaimKey.ListeOpsparedeTillaegsydelser),
            ClaimKey.GodkendNaturalieYdelsesSatser => nameof(ClaimKey.GodkendNaturalieYdelsesSatser),
            ClaimKey.GodkendUdbetalingsSatser => nameof(ClaimKey.GodkendUdbetalingsSatser),
            ClaimKey.SoegIBrugerLog => nameof(ClaimKey.SoegIBrugerLog),
            ClaimKey.VisPlanlagteFlytningerHistorik => nameof(ClaimKey.VisPlanlagteFlytningerHistorik),
            ClaimKey.VisKontraktopfyldelseHistorik => nameof(ClaimKey.VisKontraktopfyldelseHistorik),
            ClaimKey.ListeRolleoversigt => nameof(ClaimKey.ListeRolleoversigt),
            ClaimKey.ListeRettighedsoversigt => nameof(ClaimKey.ListeRettighedsoversigt),
            ClaimKey.ListeIndkvarteredePlanlaegFlytning => nameof(ClaimKey.ListeIndkvarteredePlanlaegFlytning),
            ClaimKey.Portvagt => nameof(ClaimKey.Portvagt),
            ClaimKey.ListeFaseBeregningsRegler => nameof(ClaimKey.ListeFaseBeregningsRegler),
            ClaimKey.GodkendOescFilesNavision => nameof(ClaimKey.GodkendOescFilesNavision),
            ClaimKey.AfsendOescFilesNavision => nameof(ClaimKey.AfsendOescFilesNavision),
            ClaimKey.ListeOescFilesNavisionStatus => nameof(ClaimKey.ListeOescFilesNavisionStatus),
            ClaimKey.VisCenterHistorik => nameof(ClaimKey.VisCenterHistorik),
            ClaimKey.RedigerVæerdilisteIndkvarteringstyper => nameof(ClaimKey.RedigerVæerdilisteIndkvarteringstyper),
            ClaimKey.ListePersonerFyldt18 => nameof(ClaimKey.ListePersonerFyldt18),
            ClaimKey.ListeFradragIndtastFradragOgGem => nameof(ClaimKey.ListeFradragIndtastFradragOgGem),
            ClaimKey.SaetYdelseSpaerrekort => nameof(ClaimKey.SaetYdelseSpaerrekort),
            ClaimKey.FjernYdelseSpaerrekort => nameof(ClaimKey.FjernYdelseSpaerrekort),
            ClaimKey.EditPlanlagtFlytInd => nameof(ClaimKey.EditPlanlagtFlytInd),
            ClaimKey.OpretPligter => nameof(ClaimKey.OpretPligter),
            ClaimKey.VisPligthistorik => nameof(ClaimKey.VisPligthistorik),
            ClaimKey.VisStopdatoHistorik => nameof(ClaimKey.VisStopdatoHistorik),
            _ => value.ToString(),
        };
    }

    public enum ClaimKey
    {
        /// <summary>
        /// Default claim
        /// </summary>
        None = 0,
        /// <summary>
        /// Adgang til søge efter person
        /// </summary>
        SoegPerson = 10,
        /// <summary>
        /// Adgang til at se basisdata og faner på personkort
        /// </summary>
        PersonkortBasis = 20,
        /// <summary>
        /// Adgang til stamdata på personkort
        /// </summary>
        Stamdata = 30,
        /// <summary>
        /// Adgang til at se fanen relationer på personkort
        /// </summary>
        FanenRelationer = 40,
        /// <summary>
        /// Adgang til at redigere stamdata på personkort
        /// </summary>
        RedigerStamdata = 50,
        /// <summary>
        /// Adgang til at redigere ydelsesrelateret relation
        /// </summary>
        RedigerYdelseRelation = 60,
        /// <summary>
        /// Adgang til at oprette ydelsesrelateret relation
        /// </summary>
        OpretYdelseRelation = 70,
        /// <summary>
        /// Adgang til at se liste over ydelsesrelaterede relationer
        /// </summary>
        VisYdelseRelation = 80,
        /// <summary>
        /// Adgang til at redigere booking-relateret relation
        /// </summary>
        RedigerBookingRelation = 90,
        /// <summary>
        /// Adgang til at oprette booking-relateret relation
        /// </summary>
        OpretBookingRelation = 100,
        /// <summary>
        /// Adgang til at se liste over booking-relaterede relationer
        /// </summary>
        VisBookingRelation = 110,
        /// <summary>
        /// Adgang til at se fanen indkvartering på personkort
        /// </summary>
        FanenIndkvartering = 120,
        /// <summary>
        /// Adgang til funktionaliteten Flyt Ind
        /// </summary>
        FlytInd = 130,
        /// <summary>
        /// Adgang til funktionaliteten Flyt ud
        /// </summary>
        FlytUd = 140,
        /// <summary>
        /// Adgang til at se listen Aktuel Indkvartering på personkort
        /// </summary>
        VisAktuelIndkvartering = 150,
        /// <summary>
        /// Adgang til at redigere aktuel indkvartering på personkort
        /// </summary>
        RedigerAktuelIndkvartering = 160,
        /// <summary>
        /// Adgang til at oprette flyttespærring
        /// </summary>
        OpretFlyttespaerring = 170,
        /// <summary>
        /// Adgang til at ophæve flyttespærring
        /// </summary>
        OphaevFlyttespaerring = 180,
        /// <summary>
        /// Adgang til at se listen planlagt flytning på personkort
        /// </summary>
        VisPlanlagtFlytning = 190,
        /// <summary>
        /// Adgang til at se listen tidligere indkvarteringer på personkort
        /// </summary>
        VisTidligereIndkvartering = 200,
        /// <summary>
        /// Adgang til at se listen indkvarteringshistorik på personkort
        /// </summary>
        VisIndkvarteringHistorik = 210,
        /// <summary>
        /// Adgang til at se fanen Modtagefunktioner på personkort
        /// </summary>
        FanenModtagefunktioner = 220,
        /// <summary>
        /// Adgang til at se listen Modtagefunktioner på personkort
        /// </summary>
        VisModtagefunktioner = 230,
        /// <summary>
        /// Adgang til at oprette modtagefunktion
        /// </summary>
        OpretModtagefunktion = 240,
        /// <summary>
        /// Adgang til at redigere modtagefunktion
        /// </summary>
        RedigerModtagefunktion = 250,
        /// <summary>
        /// Adgang til at se fanen Planlæg Flytning på personkort
        /// </summary>
        FanenPlanlaegFlytning = 260,
        /// <summary>
        /// Adgang til at se listen Vurderingsgrundlag på personkort
        /// </summary>
        VisVurderingsgrundlag = 270,
        /// <summary>
        /// Adgang til at sætte markeringen Flytteklar
        /// </summary>
        SaetFlytteklar = 280,
        /// <summary>
        /// Adgang til at ophæve markeringen Flytteklar
        /// </summary>
        SaetIkkeFlytteklar = 290,
        /// <summary>
        /// Adgang til at oprette en planlagt flytning
        /// </summary>
        OpretPlanlagtFlytning = 300,
        /// <summary>
        /// Adgang til at redigere en planlagt flytning
        /// </summary>
        RedigerPlanlagtFlytning = 310,
        /// <summary>
        /// Adgang til at se fanen ydelser på personkort
        /// </summary>
        FanenYdelser = 320,
        /// <summary>
        /// Adgang til at sætte stopdato for ydelse
        /// </summary>
        SaetYdelseStopdato = 330,
        /// <summary>
        /// Adgang til at fjerne stopdato for ydelse
        /// </summary>
        FjernYdelseStopdato = 340,
        /// <summary>
        /// Adgang til at oprette manuel udbetaling
        /// </summary>
        OpretManuelUdbetaling = 350,
        /// <summary>
        /// Adgang til at oprette individuelt beregningsgrundlag
        /// </summary>
        OpretIndividueltBeregningsgrundlag = 360,
        /// <summary>
        /// Adgang til at slette individuelt beregningsgrundlag
        /// </summary>
        SletIndividueltBeregningsgrundlag = 370,
        /// <summary>
        /// Adgang til at se opsparede tillægsydelser
        /// </summary>
        VisOpsparedetillægsydelser = 380,
        /// <summary>
        /// Adgang til at slette tillægsydelse
        /// </summary>
        SletTillaegsydelse = 390,
        /// <summary>
        /// Adgang til at se udbetalingsspecifikationer
        /// </summary>
        VisUdbetalingsspecifikationer = 400,
        /// <summary>
        /// Adgang til at se fanen naturalieydelser
        /// </summary>
        FanenNaturalieydelser = 410,
        /// <summary>
        /// Adgang til at se manuel naturalieudlevering
        /// </summary>
        VisManuelNaturalieudlevering = 420,
        /// <summary>
        /// Adgang til at oprette manuel naturalieudlevering
        /// </summary>
        OpretManuelNaturalieudlevering = 430,
        /// <summary>
        /// Adgang til at se Modtager Naturalieydelser På Vegne Af 
        /// </summary>
        VisModtagerNaturalieYdelserPaaVegneAf = 440,
        /// <summary>
        /// Adgang til listen Modtagefunktioner
        /// </summary>
        ListeModtagefunktioner = 450,
        /// <summary>
        /// Adgang til at se listen Måske flytteklare fra modtagecenter
        /// </summary>
        ListeMaaskeFlytteklareFraModtagecenter = 460,
        /// <summary>
        /// Adgang til listen Flytteklare personer
        /// </summary>
        ListeFlytteklarePersoner = 470,
        /// <summary>
        /// Adgang til at planlægge flytning fra listen Flytteklare personer
        /// </summary>
        ListeFlytteklarePlanlaegFlytning = 480,
        /// <summary>
        /// Adgang til listen planlagte indflytninger
        /// </summary>
        ListePlanlagteIndflytninger = 490,
        /// <summary>
        /// Adgang til funktionaliteten Flyt ind fra listen planlagte indflytninger
        /// </summary>
        ListePlanlagteIndflytningerFlytInd = 500,
        /// <summary>
        /// Adgang til listen planlagte udflytninger
        /// </summary>
        ListePlanlagteUdflytninger = 510,
        /// <summary>
        /// Adgang til funktionaliteten Flyt ud fra listen planlagte udflytninger
        /// </summary>
        ListePlanlagteUdflytningerFlytUd = 520,
        /// <summary>
        /// Adgang til listen Overskredne planlagte indflytninger
        /// </summary>
        ListeOverskrednePlanlagteIndflytninger = 530,
        /// <summary>
        /// Adgang til funktionaliteten Flyt ind fra listen overskredne planlagte indflytninger
        /// </summary>
        ListeOverskrednePlanlagteIndflytningerFlytInd = 540,
        /// <summary>
        /// Adgang til listen indflytninger
        /// </summary>
        ListeIndflytninger = 550,
        /// <summary>
        /// Adgang til listen udflytninger
        /// </summary>
        ListeUdflytninger = 560,
        /// <summary>
        /// Adgang til listen Indkvarterede personer
        /// </summary>
        ListeIndkvarteredePersoner = 570,
        /// <summary>
        /// Adgang til listen Ledsagede - uledsagede børn
        /// </summary>
        ListeLedsagedeUledsagedeBoern = 580,
        /// <summary>
        /// Adgang til listen Familieliste
        /// </summary>
        ListeFamilielisten = 590,
        /// <summary>
        /// Adgang til listen Personer indskrevet på mere end et center
        /// </summary>
        ListePersonerIndskrevetPaaMereEndEtCenter = 600,
        /// <summary>
        /// Adgang til listen Personer med dobbelte indkvarteringer
        /// </summary>
        ListePersonerMedDobbeltIndkvarteringer = 610,
        /// <summary>
        /// Adgang til listen Udeblevne fra center
        /// </summary>
        ListeUdeblevneFraCenter = 620,
        /// <summary>
        /// Adgang til listen Udrejste personer
        /// </summary>
        ListeUdrejstePersoner = 630,
        /// <summary>
        /// Adgang til listen Kommende integrationer
        /// </summary>
        ListeKommendeIntegrationer = 640,
        /// <summary>
        /// Adgang til listen Overskredne integrationer
        /// </summary>
        ListeOverskredneIntegrationer = 650,
        /// <summary>
        /// Adgang til listen Kapacitetsoversigt
        /// </summary>
        ListeKapacitetsoversigt = 660,
        /// <summary>
        /// Adgang til listen Belægningsdøgn
        /// </summary>
        ListeBelaegningsdoegn = 670,
        /// <summary>
        /// Adgang til listen Månedsrapport belægningsdøgn 
        /// </summary>
        ListeMaanedsrapportBelaegningsdoegn = 680,
        /// <summary>
        /// Adgang til listen Årskorrektioner belægningsdøgn 
        /// </summary>
        ListeAarskorrektionerBelaegningsdoegn = 690,
        /// <summary>
        /// Adgang til listen Månedsrapport Modtagefunktioner
        /// </summary>
        ListeMaanedsrapportModtagefunktioner = 700,
        /// <summary>
        /// Adgang til listen Udbetalingsliste
        /// </summary>
        ListeUdbetalingsliste = 710,
        /// <summary>
        /// Adgang til funktionen kvitter og gem på udbetalingsliste
        /// </summary>
        ListeUdbetalingslisteKvitterOgGem = 720,
        /// <summary>
        /// Adgang til listen Manuel udbetalingsliste
        /// </summary>
        ListeManuelUdbetalingsliste = 730,
        /// <summary>
        /// Adgang til funktionen kvitter og gem på manuel udbetalingsliste
        /// </summary>
        ListeManuelUdbetalignslisteKvitterOgGem = 740,
        /// <summary>
        /// Adgang til listen Omposteringsliste
        /// </summary>
        ListeOmposteringsliste = 750,
        /// <summary>
        /// Adgang til listen Naturalieliste
        /// </summary>
        ListeNaturalieliste = 760,
        /// <summary>
        /// Adgang til funktionen kvitter og gem på naturalieliste
        /// </summary>
        ListeNaturalielisteKvitterOgGem = 770,
        /// <summary>
        /// Adgang til listen Manuel naturalieliste
        /// </summary>
        ListeManuelNaturalieliste = 780,
        /// <summary>
        /// Adgang til funktionen kvitter og gem på manuel naturalieliste
        /// </summary>
        ListeManuelNaturalielisteKvitterOgGem = 790,
        /// <summary>
        /// Adgang til listen NaturalieSpecifikation
        /// </summary>
        ListeNaturalieSpecifikation = 800,
        /// <summary>
        /// Adgang til listen Kontrakopfyldelse (VUA)
        /// </summary>
        ListeKontraktopfyldelse = 810,
        /// <summary>
        /// Adgang til funktionen Indtast kontrakopfyldelse og gem på listen Kontraktopfyldelse (VUA)
        /// </summary>
        ListeKontraktopfyldelseIndtastKontraktopfyldelseOgGem = 820,
        /// <summary>
        /// Adgang til listen Møntenhedsspecifikation
        /// </summary>
        ListeMoentenhedsspecifikation = 830,
        /// <summary>
        /// Adgang til listen ÅGH-liste
        /// </summary>
        ListeAaghListe = 840,
        /// <summary>
        /// Adgang til listen Personer på fase
        /// </summary>
        ListeOverPersonerPaaFase = 850,
        /// <summary>
        /// Adgang til at redigere centermeddelelser
        /// </summary>
        RedigerCentermeddelelse = 860,
        /// <summary>
        /// Adgang til at oprette operatør
        /// </summary>
        OpretOperatoer = 870,
        /// <summary>
        /// Adgang til at redigere operatør
        /// </summary>
        RedigerOperatoer = 880,
        /// <summary>
        /// Adgang til at oprette center
        /// </summary>
        OpretCenter = 890,
        /// <summary>
        /// Adgang til at se liste over operatører
        /// </summary>
        VisOperatører = 900,
        /// <summary>
        /// Adgang til at liste over nedlagte centre
        /// </summary>
        VisNedlagteCentre = 910,
        /// <summary>
        /// Adgang til at genaktivere et nedlagt center
        /// </summary>
        GenaktiverNedlagtCenter = 920,
        /// <summary>
        /// Adgang til at se liste over centre
        /// </summary>
        VisCentre = 930,
        /// <summary>
        /// Adgang til at redigere et center
        /// </summary>
        RedigerCenter = 940,
        /// <summary>
        /// Adgang til at nedlægge et center
        /// </summary>
        NedlaegCenter = 950,
        /// <summary>
        /// Adgang til at oprette et indkvarteringssted
        /// </summary>
        OpretIndkvarteringssted = 960,
        /// <summary>
        /// Adgang til at redigere et indkvarteringssted
        /// </summary>
        RedigerIndkvarteringssted = 970,
        /// <summary>
        /// Adgang til at nedlægge et indkvarteringssted
        /// </summary>
        NedlaegIndkvarteringssted = 980,
        /// <summary>
        /// Adgang til at se liste over kontante ydelser
        /// </summary>
        VisKontanteYdelser = 990,
        /// <summary>
        /// Adgang til at oprette kontantydelse
        /// </summary>
        OpretKontantydelse = 1000,
        /// <summary>
        /// Adgang til at slette kontantydelse
        /// </summary>
        SletKontantydelse = 1010,
        /// <summary>
        /// Adgang til at se liste over naturalieydelser
        /// </summary>
        VisNaturalieYdelser = 1020,
        /// <summary>
        /// Adgang til at oprette naturalieydelse
        /// </summary>
        OpretNaturalieydelse = 1030,
        /// <summary>
        /// Adgang til at slette naturalieydelse
        /// </summary>
        SletNaturalieydelse = 1040,
        /// <summary>
        /// Adgang til at oprette person
        /// </summary>
        OpretPerson = 1050,
        /// <summary>
        /// Adgang til at redigere indflytningsårsager
        /// </summary>
        RedigerVæerdilisteIndflytningsårsager = 1060,
        /// <summary>
        /// Adgang til at redigere udflytningsårsager
        /// </summary>
        RedigerVæerdilisteUdflytningsårsager = 1070,
        /// <summary>
        /// Adgang til at redigere bookingrelationstype
        /// </summary>
        RedigerVæerdilisteBookingRelationTyper = 1080,
        /// <summary>
        /// Adgang til at redigere modtagefunktiontyper
        /// </summary>
        RedigerVæerdilisteModtagefunktionTyper = 1090,
        /// <summary>
        /// Adgang til at redigere flyttespaerringsårsager
        /// </summary>
        RedigerVæerdilisteFlyttespaerringsAarsager = 1100,
        /// <summary>
        /// Adgang til alle personer uanset brugers centertilknytning
        /// </summary>
        AdgangTilAllePersoner = 1120,
        /// <summary>
        /// Adgang til US-forside
        /// </summary>
        USForside = 1130,
        /// <summary>
        /// Adgang til Center-forside
        /// </summary>
        CenterForside = 1140,
        /// <summary>
        /// Adgang til Administrationsforside
        /// </summary>
        AdministrationsForside = 1150,
        /// <summary>
        /// Adgang til listen Kasseafstemning
        /// </summary>
        ListeKasseafstemning = 1160,
        /// <summary>
        /// Adgang til at redigere modtagekategorier
        /// </summary>
        RedigerVæerdilisteModtagekategorier = 1170,
        /// <summary>
        /// Adgang til at se kontraktopfyldelse
        /// </summary>
        VisKontraktopfyldelse = 1190,
        /// <summary>
        /// Adgang til at gemme data vedr kontraktopfyldelse
        /// </summary>
        RedigerKontraktopfyldelse = 1200,
        /// <summary>
        /// Adgang til listen Avanceret
        /// </summary>
        ListeAvanceret = 1210,
        /// <summary>
        /// Adgang til at redigerer hvilke brugere der er tilknyttet et center
        /// </summary>
        RedigerCenterBruger = 1220,
        /// <summary>
        /// Adgang til at redigere en persons fase manuelt
        /// </summary>
        RedigerFaseManuelt = 1230,
        /// <summary>
        /// Adgang til at blive kaldt fra Drk Web service
        /// </summary>
        KaldFraDrkService = 1240,
        /// <summary>
        /// Adgang til at redigere bygningstyper værdilisten
        /// </summary>
        RedigerVæerdilisteBygningstyper = 1250,
        /// <summary>
        /// Adgang til at redigere satser for ydelser
        /// </summary>
        RedigerYdelseSatser = 1260,
        /// <summary>
        /// Adgang til at redigere satser for naturalier
        /// </summary>
        RedigerNaturalieSatser = 1270,
        /// <summary>
        /// Adgang til at redigere Ågh under stamdata
        /// </summary>
        RedigerStamdataAagh = 1280,
        /// <summary>
        /// Adgang til at redigere ledsaget type under stamdata
        /// </summary>
        RedigerStamdataLedsagetType = 1290,
        /// <summary>
        /// Adgang til listen Voksentøjspakker
        /// </summary>
        ListeVoksenToejpakker = 1300,
        /// <summary>
        /// Adgang til listen Individuelt Beregningsgrundlag
        /// </summary>
        ListeIndividueltBeregningsgrundlag = 1310,
        /// <summary>
        /// Adgang til listen Opsparede tillægsydelser
        /// </summary>
        ListeOpsparedeTillaegsydelser = 1320,
        /// <summary>
        /// Adgang til at kunne godkende naturalieydelsessatser
        /// </summary>
        GodkendNaturalieYdelsesSatser = 1330,
        /// <summary>
        /// Adgang til at kunne godkende udbetalingssatser
        /// </summary>
        GodkendUdbetalingsSatser = 1340,
        /// <summary>
        /// Adgang til at kunne søge i bruger log
        /// </summary>
        SoegIBrugerLog = 1350,
        /// <summary>
        /// Adgang til at kunne se historik på planlagte flytninger
        /// </summary>
        VisPlanlagteFlytningerHistorik = 1360,
        /// <summary>
        /// Adgang til at kunne se historik på kontraktopfyldelse
        /// </summary>
        VisKontraktopfyldelseHistorik = 1370,
        /// <summary>
        /// Adgang til listen Rolleoversigt
        /// </summary>
        ListeRolleoversigt = 1380,
        /// <summary>
        /// Adgang til listen Rettighedsoversigt
        /// </summary>
        ListeRettighedsoversigt = 1390,
        /// <summary>
        /// Adgang til at kunne masseplanlægge flytninger fra listen over indkvarterede personer.
        /// </summary>
        ListeIndkvarteredePlanlaegFlytning = 1400,
        /// <summary>
        /// Adgang til at kunne se faseberegningsregler listen
        /// </summary>
        ListeFaseBeregningsRegler = 1410,
        /// <summary>
        /// Adgang til at kunne bruge portvagt skærmbilledet.
        /// </summary>
        Portvagt = 1420,
        /// <summary>
        /// Adgang til at kunne godkende ØSC filer til Navision
        /// </summary>
        GodkendOescFilesNavision = 1430,
        /// <summary>
        /// Adgang til at kunne afsende ØSC filer til Navision
        /// </summary> 
        AfsendOescFilesNavision = 1440,
        /// <summary>
        /// Adgang til listen Navision ØSC overførsler
        /// </summary> 
        ListeOescFilesNavisionStatus = 1450,
        /// <summary>
        /// Adgang til at få vist historik på center lokation og Navision kontooplysninger
        /// </summary> 
        VisCenterHistorik = 1460,
        /// <summary>
        /// Adgang til at redigere indkvarteringstyper værdilisten
        /// </summary>
        RedigerVæerdilisteIndkvarteringstyper = 1470,
        /// <summary>
        /// Adgang til at se liste over Personer der er fyldt 18
        /// </summary>
        ListePersonerFyldt18 = 1480,
        /// <summary>
        /// Adgang til funktionen Indtast fradrag og gem på listen Fradrag i tillægsydelser
        /// </summary>
        ListeFradragIndtastFradragOgGem = 1490,
        /// <summary>
        /// Adgang til at sætte spærrekort for ydelse
        /// </summary>
        SaetYdelseSpaerrekort = 1500,
        /// <summary>
        /// Adgang til at fjerne spærrekort for ydelse
        /// </summary>
        FjernYdelseSpaerrekort = 1510,
        /// <summary>
        /// Adgang til at editere indflytningsvalg ved Flyt ind fra planlagt flytning
        /// </summary>
        EditPlanlagtFlytInd = 1520,
        /// <summary>
        /// Adgang til at oprette pligter
        /// </summary>
        OpretPligter = 1530,
        /// <summary>
        /// Adgang til at se listen pligthistorik på personkort
        /// </summary>
        VisPligthistorik = 1540,
        /// <summary>
        /// Adgang til at se listen stopdatohistorik på personkort
        /// </summary>
        VisStopdatoHistorik = 1550
    }
}
