using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aircraftCreator
{
    class Aircraft
    {
        /****User Selections****/
        private string ac_id { get; set; }
        private string ACconfigName { get; set; }
        private double wPayload { get; set; }
        private int ACtype { get; set; }
        private double range { get; set; }
        private double cruiseSpeed { get; set; }
        private int propConfig { get; set; }
        private double wingSpan { get; set; }
        private int wingConfig { get; set; }
        private double sweepAngle { get; set; }
        private double rootCordLength { get; set; }
        private int landingGearConfig { get; set; }

        /****Static Values****/
        private double wCrew { get; set; }//Static value of 280lbs or 127kg
        private double wFuelClimbRatio { get; set; }// static value based on pg.34 Table 3.2
        private double wFuelLandRatio { get; set; }// static value based on pg.34 Table 3.2
        private double endurance { get; set; }//static value of 1,800 seconds or 45 minutes;FAA IFR Requirement 
        private int missionProfile { get; set; } // static till more mission profiles are added
        private double LDCoeffCruise { get; set; } // static until new Aircraft configurations added; set in ACtype
        private double LDCoeffLoiter { get; set; } // static until new Aircraft configurations added; set in ACtype

        /****Calculated Values****/
        private double emptyRatioKvs { get; set; }
        private double emptyRatioA { get; set; }
        private double emptyRatioC { get; set; }
        private double initialWeight { get; set; }
        private double initialWeightguess { get; set; }
        private double wTORatio { get; set; }
        private double wFuel { get; set; }
        private double wEmpty { get; set; }
        private double wEmptyRatio { get; set; }
        private double wFuelRatio { get; set; }
        private double wFuelCruiseRatio { get; set; }
        private double wFuelLoiterRatio { get; set; }
        private double SFCfuelCruise { get; set; }
        private double SFCfuelLoiter { get; set; }
        private double aspectRatio { get; set; }
        private double sWetsRefRatio { get; set; }
        private double CbhpCruise { get; set; }
        private double CbhpLoiter { get; set; }
        private double thrustEfficiency { get; set; }
        private double K_LD { get; set; }
        private double LDmax { get; set; }
        private double liftDragRatioLoiter { get; set; }
        private double liftDragRatioCruise { get; set; }
        private double s_ref { get; set; }

        //*************************SETTERS*************************
        public void setACconfigName(string Name)
        {
            ACconfigName = Name;
        }
        public void setACconfig(string ACtype, string Payload, string Velocity, string Range, string PropConfig, string Wingspan, string WingConfig, string Sweep, string Cord, string LandingGear, string MissionProfile)
        {
            setACtype(Int32.Parse(ACtype));
            setwPayload(Double.Parse(Payload));
            setVelocity(Double.Parse(Velocity));
            setRange(Double.Parse(Range));
            setPropConfig(Int32.Parse(PropConfig));
            setWingSpan(Double.Parse(Wingspan));
            setWingConfig(Int32.Parse(WingConfig));
            setSweepAngle(Double.Parse(Sweep));
            setRootCordLength(Double.Parse(Cord));
            setLandingGearConfig(Int32.Parse(LandingGear));
            setMissionProfile(Int32.Parse(MissionProfile));

        }
        public void setWingConfig(int config)
        {
            wingConfig = config;
        }
        public void setPropConfig(int config)
        {
            switch (config)
            {
                case 0:
                    setThrustEfficiency(.7);
                    setSFCfuelCruise(0.068);
                    setSFCfuelLoiter(0.085);
                    break;
                case 1:
                    setThrustEfficiency(.8);
                    setSFCfuelCruise(.068);
                    setSFCfuelLoiter(0.085);
                    break;
                case 2:
                    setThrustEfficiency(.8);
                    setSFCfuelCruise(.085);
                    setSFCfuelLoiter(.101);
                    break;
                default:
                    setThrustEfficiency(.8);
                    setSFCfuelCruise(.068);
                    setSFCfuelLoiter(0.085);
                    break;
            }
        }
        public void setLandingGearConfig(int lgConfig)
        {
            landingGearConfig = lgConfig;
            switch (lgConfig)
            {
                case 0:
                    setK_LD(11);
                    break;
                case 1:
                    setK_LD(9);
                    break;
            }
        }
        public void setACtype(int acType)
        {
            ACtype = acType;
            switch (acType)
            {
                case 0:
                    setInitialWeightGuess(1000);//***Initial weight guess set using Fig 3.1 on Pg 30***//

                    //***Empty weight ration values set using Table 3.1 Pg 31***//
                    setEmptyRatioA(2.05);
                    setEmptyRatioC(-0.18);
                    setEmptyRatioKvs(1.0);
                    
                    //***Lift Drag Coefficeints set using unlabeled table on Pg 41***//
                    setLDCoeffLoiter(0.866);
                    setLDCoeffCruise(1.0);
                    break;

                case 1:
                    setInitialWeightGuess(3000);//***Initial weight guess set using Fig3.1 on page 30***//

                    //***Empty weight ration values set using Table 3.1 Pg 31***//
                    setEmptyRatioA(1.4);
                    setEmptyRatioC(-0.10);
                    setEmptyRatioKvs(1.0);

                    //***Lift Drag Coefficeints set using unlabeled table on Pg 41***//
                    setLDCoeffLoiter(0.866);
                    setLDCoeffCruise(1.0);
                    break;
            }
        }
        public void setwPayload(double payload)
        {
            wPayload = payload;
        }
        public void setMissionProfile(int mission)
        {
            missionProfile = mission;
        }
        public void setLDCoeffLoiter(double coeff)
        {
            LDCoeffLoiter = coeff;
        }
        public void setLDCoeffCruise(double coeff)
        {
            LDCoeffCruise = coeff;
        }
        public void setSWetsRefRatio()
        {
            int aircraftType = getACtype();
            int wingConfig = getWingConfig();
            if (aircraftType == 0 && wingConfig == 0)
            {
                sWetsRefRatio = 3.9;
            }
            else if (aircraftType == 0 && wingConfig == 1)
            {
                sWetsRefRatio = 3.0;
            }
            else if (aircraftType == 1 && wingConfig == 0)
            {
                sWetsRefRatio = 5.0;
            }
            else if (aircraftType == 1 && wingConfig == 1)
            {
                sWetsRefRatio = 4.1;
            }
        }
        public void setS_ref()
        {
            if (getWingConfig() == 0) //Conventional Wing Reference Surface Area
            {
                s_ref = getRootCordLength() * getWingSpan();
            }
            else //Delta Wing Reference Surface Area
            {
                double w = 2 * getRootCordLength() * Math.Tan((90-getSweepAngle())* 3.14 / 180) ;
                double l = (w - getWingSpan())/(2 * Math.Tan((90-getSweepAngle())* 3.14 / 180));
                s_ref = .5 * (getRootCordLength() * w - l*(w-getWingSpan()));
            }
        }
        public void setRootCordLength(double cord)
        { rootCordLength = cord; }
        public void setK_LD(double kld)
        { K_LD = kld; }
        public void setWingSpan(double span)
        { wingSpan = span; }
        public void setEndurance(double time)
        { endurance = time; }
        public void setRange(double r)
        { range = r; }
        public void setSFCfuelCruise(double sfc)
        { SFCfuelCruise = .000138;
            // Bug in calculation that needs to be pinned down. Returning NAN on final result when using this calc
            //sfc* getCruiseSpeed() / (1000000 * getThrustEfficiency()/550); 
        }
        public void setSFCfuelLoiter(double sfc)
        {
            SFCfuelLoiter = .000111; 
                //sfc*getCruiseSpeed()/(1000000 * getThrustEfficiency()/550);
        }
        public void setVelocity(double v)
        { cruiseSpeed = v; }
        public void setInitialWeightGuess(double w0)
        {
            initialWeightguess = w0;
        }
        public void setLDmax()
        {
            LDmax = getK_LD() * Math.Pow(getaspectRatio()/getsWetsRefRatio(),.5);
        }
        public void setLiftDragRatioCruise()
        {
            double ldMax = getLDmax();
            double Cld = getLDCoeffCruise();
            liftDragRatioCruise = ldMax * Cld;
        }
        public void setLiftDragRatioLoiter()
        {
            liftDragRatioLoiter = getLDmax() * getLDCoeffLoiter();
        }
        public void setSFCfuelLoiter()
        {
            SFCfuelLoiter = getCbhpLoiter() * getCruiseSpeed() / getThrustEfficiency();
        }
        public void setThrustEfficiency(double np)
        {
            thrustEfficiency = np;
        }
        public void setaspectRatio()
        {
            setS_ref();
            aspectRatio = Math.Pow(getWingSpan(), 2) / getS_ref();
        }
        public void setwFuelCruiseRatio()
        {
            double r = getRange();
            double sfc = getSFCfuelCruise();
            double v = getCruiseSpeed();
            double ld = getLiftDragRatioCruise();
            wFuelCruiseRatio = Math.Pow(2.71828, -1 * r * sfc / (v * ld));
        }
        public void setwFuelLoiterRatio()
        {
            double E = getEndurance();
            double sfc = getSFCfuelLoiter();
            double ld = getLiftDragRatioLoiter();
            wFuelLoiterRatio = Math.Pow(2.71828,-1 * E * sfc / ld);
        }
        public void setwEmptyRatio()
        {
            double A = getEmptyRatioA();
            double w0 = getInitialWeightGuess();
            double C = getEmptyRatioC();
            double Kvs = getEmptyRatioKvs();
            wEmptyRatio = A * Math.Pow(w0, C) * Kvs;
        }
        public void setwCrew(double wt)
        { wCrew = wt; }
        public void setEmptyRatioKvs(double val)
        { emptyRatioKvs = val; }
        public void setEmptyRatioC(double val)
        { emptyRatioC = val; }
        public void setEmptyRatioA(double val)
        { emptyRatioA = val; }

        public string getACconfigName()
        { return ACconfigName; }
        public double getEmptyRatioKvs()
        { return emptyRatioKvs;}
        public double getEmptyRatioC()
        { return emptyRatioC; }
        public double getEmptyRatioA()
        { return emptyRatioA; }
        public int getMissionProfile()
        { return missionProfile; }
        public void setwFuelRatio1()
        {
            int mission = getMissionProfile();

            double wTO = getwTORatio();
            double wClimb = getwClimbFuel();
            double wCruise = getwFuelCruiseRatio();
            double wLoiter = getwFuelLoiterRatio();
            double wLand = getwLandFuel();

            switch (mission)
            {
                case 0:
                    wFuelRatio = 1.06 * (1 - wTO * wClimb * wCruise * wLoiter * wLand);
                    break;

                default:
                    wFuelRatio = 1.06 * (1 - wTO * wClimb * wCruise * wLoiter * wLand);
                    break;
            }
        }
        public void setSweepAngle(double angle)
        { sweepAngle = angle; }
        public double getwLandFuel()
        { return wFuelLandRatio; }
        public double getwClimbFuel()
        { return wFuelClimbRatio; }
        public int getWingConfig()
        { return wingConfig; }
        public int getACtype()
        { return ACtype; }
        public double getS_ref()
        { return s_ref; }
        public double getRootCordLength()
        { return rootCordLength; }
        public double getSweepAngle()
        { return sweepAngle; }
        public double getLDCoeffLoiter()
        { return LDCoeffLoiter; }
        public double getLDCoeffCruise()
        { return LDCoeffCruise; }
        public double getLiftDragRatioLoiter()
        { return liftDragRatioLoiter; }
        public double getLiftDragRatioCruise()
        { return liftDragRatioCruise; }
        public double getwFuelLoiterRatio()
        { return wFuelLoiterRatio; }
        public double getwFuelCruiseRatio()
        { return wFuelCruiseRatio; }
        public double getwTORatio()
        { return wTORatio; }
        public double getLDmax()
        { return LDmax; }
        public double getK_LD()
        { return K_LD; }
        public double getThrustEfficiency()
        { return thrustEfficiency; }
        public double getCbhpCruise()
        { return CbhpCruise; }
        public double getCbhpLoiter()
        { return CbhpLoiter; }
        public double getsWetsRefRatio()
        { return sWetsRefRatio; }
        public double getaspectRatio()
        { return aspectRatio; }
        public double getWingSpan()
        { return wingSpan; }
        public double getEndurance()
        { return endurance; }
        public double getSFCfuelLoiter()
        { return SFCfuelLoiter;}
        public double getSFCfuelCruise()
        { return SFCfuelCruise; }
        public double getCruiseSpeed()
        {
            return cruiseSpeed;
        }
        public double getRange()
        { 
            return range;
        }
        public double getwCrew()
        {
            return wCrew;
        }
        public double getwPayload()
        {
            return wPayload;
        }
        public double getwFuel()
        {
            return wFuel;
        }
        public double getwEmpty()
        {
            return wEmpty;
        }
        public double getwFuelRatio()
        {
            return wFuelRatio;
        }
        public double getwEmptyRatio()
        { 
            return wEmptyRatio;
        }
        public double getInitialWeight()
        {
            return initialWeight;
        }
        public double getInitialWeightGuess()
        {
            return initialWeightguess;
        }
        public void setwTORatio(double ratio)
        {
            wTORatio = ratio;
        }
        public void setwClimbFuel(double ratio)
        { wFuelClimbRatio = ratio; }
        public void setwLandFuel(double ratio)
        { wFuelLandRatio = ratio; }
        public double setInitialWeight()
        {
            setS_ref();
            setaspectRatio();
            setSWetsRefRatio();
            setLDmax();
            setLiftDragRatioCruise();
            setLiftDragRatioLoiter();
            setwFuelCruiseRatio();
            setEndurance(2700);
            setwFuelLoiterRatio();
            setwLandFuel(.995);
            setwClimbFuel(.985);
            setwTORatio(.970);
            setwFuelRatio1();
            setwCrew(127); 
            setwEmptyRatio();
            initialWeight = 0;
            int count = 0;
            bool calcInitialWeight = true;
            while (count <= 100 && calcInitialWeight)
            {
                double wC = getwCrew();
                double wP = getwPayload();
                double wFR = getwFuelRatio();
                double wER = getwEmptyRatio();
                initialWeight = (wC + wP) / (1 - wFR - wER);

                if(getInitialWeight() > getInitialWeightGuess() - 1 && getInitialWeight() <= getInitialWeightGuess() + 1)
                {
                    calcInitialWeight = false;
                }
                else
                {
                    setInitialWeightGuess(getInitialWeight());
                    setwEmptyRatio();
                }
                count++;
            }
        //** initialWeight
        //** initialWeightguess

            return getInitialWeight();
        }
    }

    public class AircraftName
    {
        public int ac_id { get; set; }
        public string ac_Name { get; set; }
    }
}
