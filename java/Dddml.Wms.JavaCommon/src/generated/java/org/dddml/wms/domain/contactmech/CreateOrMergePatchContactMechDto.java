package org.dddml.wms.domain.contactmech;

import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchContactMechDto extends AbstractContactMechCommandDto
{
    /**
     * Contact Mech Type Id
     */
    private String contactMechTypeId;

    public String getContactMechTypeId()
    {
        return this.contactMechTypeId;
    }

    public void setContactMechTypeId(String contactMechTypeId)
    {
        this.contactMechTypeId = contactMechTypeId;
    }

    /**
     * Info String
     */
    private String infoString;

    public String getInfoString()
    {
        return this.infoString;
    }

    public void setInfoString(String infoString)
    {
        this.infoString = infoString;
    }

    /**
     * To Name
     */
    private String toName;

    public String getToName()
    {
        return this.toName;
    }

    public void setToName(String toName)
    {
        this.toName = toName;
    }

    /**
     * Attn Name
     */
    private String attnName;

    public String getAttnName()
    {
        return this.attnName;
    }

    public void setAttnName(String attnName)
    {
        this.attnName = attnName;
    }

    /**
     * Address1
     */
    private String address1;

    public String getAddress1()
    {
        return this.address1;
    }

    public void setAddress1(String address1)
    {
        this.address1 = address1;
    }

    /**
     * Address2
     */
    private String address2;

    public String getAddress2()
    {
        return this.address2;
    }

    public void setAddress2(String address2)
    {
        this.address2 = address2;
    }

    /**
     * Directions
     */
    private String directions;

    public String getDirections()
    {
        return this.directions;
    }

    public void setDirections(String directions)
    {
        this.directions = directions;
    }

    /**
     * City
     */
    private String city;

    public String getCity()
    {
        return this.city;
    }

    public void setCity(String city)
    {
        this.city = city;
    }

    /**
     * Postal Code
     */
    private String postalCode;

    public String getPostalCode()
    {
        return this.postalCode;
    }

    public void setPostalCode(String postalCode)
    {
        this.postalCode = postalCode;
    }

    /**
     * Postal Code Ext
     */
    private String postalCodeExt;

    public String getPostalCodeExt()
    {
        return this.postalCodeExt;
    }

    public void setPostalCodeExt(String postalCodeExt)
    {
        this.postalCodeExt = postalCodeExt;
    }

    /**
     * Country Geo Id
     */
    private String countryGeoId;

    public String getCountryGeoId()
    {
        return this.countryGeoId;
    }

    public void setCountryGeoId(String countryGeoId)
    {
        this.countryGeoId = countryGeoId;
    }

    /**
     * State Province Geo Id
     */
    private String stateProvinceGeoId;

    public String getStateProvinceGeoId()
    {
        return this.stateProvinceGeoId;
    }

    public void setStateProvinceGeoId(String stateProvinceGeoId)
    {
        this.stateProvinceGeoId = stateProvinceGeoId;
    }

    /**
     * County Geo Id
     */
    private String countyGeoId;

    public String getCountyGeoId()
    {
        return this.countyGeoId;
    }

    public void setCountyGeoId(String countyGeoId)
    {
        this.countyGeoId = countyGeoId;
    }

    /**
     * Postal Code Geo Id
     */
    private String postalCodeGeoId;

    public String getPostalCodeGeoId()
    {
        return this.postalCodeGeoId;
    }

    public void setPostalCodeGeoId(String postalCodeGeoId)
    {
        this.postalCodeGeoId = postalCodeGeoId;
    }

    /**
     * Geo Point Id
     */
    private String geoPointId;

    public String getGeoPointId()
    {
        return this.geoPointId;
    }

    public void setGeoPointId(String geoPointId)
    {
        this.geoPointId = geoPointId;
    }

    /**
     * Country Code
     */
    private String countryCode;

    public String getCountryCode()
    {
        return this.countryCode;
    }

    public void setCountryCode(String countryCode)
    {
        this.countryCode = countryCode;
    }

    /**
     * Area Code
     */
    private String areaCode;

    public String getAreaCode()
    {
        return this.areaCode;
    }

    public void setAreaCode(String areaCode)
    {
        this.areaCode = areaCode;
    }

    /**
     * Contact Number
     */
    private String contactNumber;

    public String getContactNumber()
    {
        return this.contactNumber;
    }

    public void setContactNumber(String contactNumber)
    {
        this.contactNumber = contactNumber;
    }

    /**
     * Ask For Name
     */
    private String askForName;

    public String getAskForName()
    {
        return this.askForName;
    }

    public void setAskForName(String askForName)
    {
        this.askForName = askForName;
    }

    /**
     * Active
     */
    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }

    private Boolean isPropertyContactMechTypeIdRemoved;

    public Boolean getIsPropertyContactMechTypeIdRemoved()
    {
        return this.isPropertyContactMechTypeIdRemoved;
    }

    public void setIsPropertyContactMechTypeIdRemoved(Boolean removed)
    {
        this.isPropertyContactMechTypeIdRemoved = removed;
    }

    private Boolean isPropertyInfoStringRemoved;

    public Boolean getIsPropertyInfoStringRemoved()
    {
        return this.isPropertyInfoStringRemoved;
    }

    public void setIsPropertyInfoStringRemoved(Boolean removed)
    {
        this.isPropertyInfoStringRemoved = removed;
    }

    private Boolean isPropertyToNameRemoved;

    public Boolean getIsPropertyToNameRemoved()
    {
        return this.isPropertyToNameRemoved;
    }

    public void setIsPropertyToNameRemoved(Boolean removed)
    {
        this.isPropertyToNameRemoved = removed;
    }

    private Boolean isPropertyAttnNameRemoved;

    public Boolean getIsPropertyAttnNameRemoved()
    {
        return this.isPropertyAttnNameRemoved;
    }

    public void setIsPropertyAttnNameRemoved(Boolean removed)
    {
        this.isPropertyAttnNameRemoved = removed;
    }

    private Boolean isPropertyAddress1Removed;

    public Boolean getIsPropertyAddress1Removed()
    {
        return this.isPropertyAddress1Removed;
    }

    public void setIsPropertyAddress1Removed(Boolean removed)
    {
        this.isPropertyAddress1Removed = removed;
    }

    private Boolean isPropertyAddress2Removed;

    public Boolean getIsPropertyAddress2Removed()
    {
        return this.isPropertyAddress2Removed;
    }

    public void setIsPropertyAddress2Removed(Boolean removed)
    {
        this.isPropertyAddress2Removed = removed;
    }

    private Boolean isPropertyDirectionsRemoved;

    public Boolean getIsPropertyDirectionsRemoved()
    {
        return this.isPropertyDirectionsRemoved;
    }

    public void setIsPropertyDirectionsRemoved(Boolean removed)
    {
        this.isPropertyDirectionsRemoved = removed;
    }

    private Boolean isPropertyCityRemoved;

    public Boolean getIsPropertyCityRemoved()
    {
        return this.isPropertyCityRemoved;
    }

    public void setIsPropertyCityRemoved(Boolean removed)
    {
        this.isPropertyCityRemoved = removed;
    }

    private Boolean isPropertyPostalCodeRemoved;

    public Boolean getIsPropertyPostalCodeRemoved()
    {
        return this.isPropertyPostalCodeRemoved;
    }

    public void setIsPropertyPostalCodeRemoved(Boolean removed)
    {
        this.isPropertyPostalCodeRemoved = removed;
    }

    private Boolean isPropertyPostalCodeExtRemoved;

    public Boolean getIsPropertyPostalCodeExtRemoved()
    {
        return this.isPropertyPostalCodeExtRemoved;
    }

    public void setIsPropertyPostalCodeExtRemoved(Boolean removed)
    {
        this.isPropertyPostalCodeExtRemoved = removed;
    }

    private Boolean isPropertyCountryGeoIdRemoved;

    public Boolean getIsPropertyCountryGeoIdRemoved()
    {
        return this.isPropertyCountryGeoIdRemoved;
    }

    public void setIsPropertyCountryGeoIdRemoved(Boolean removed)
    {
        this.isPropertyCountryGeoIdRemoved = removed;
    }

    private Boolean isPropertyStateProvinceGeoIdRemoved;

    public Boolean getIsPropertyStateProvinceGeoIdRemoved()
    {
        return this.isPropertyStateProvinceGeoIdRemoved;
    }

    public void setIsPropertyStateProvinceGeoIdRemoved(Boolean removed)
    {
        this.isPropertyStateProvinceGeoIdRemoved = removed;
    }

    private Boolean isPropertyCountyGeoIdRemoved;

    public Boolean getIsPropertyCountyGeoIdRemoved()
    {
        return this.isPropertyCountyGeoIdRemoved;
    }

    public void setIsPropertyCountyGeoIdRemoved(Boolean removed)
    {
        this.isPropertyCountyGeoIdRemoved = removed;
    }

    private Boolean isPropertyPostalCodeGeoIdRemoved;

    public Boolean getIsPropertyPostalCodeGeoIdRemoved()
    {
        return this.isPropertyPostalCodeGeoIdRemoved;
    }

    public void setIsPropertyPostalCodeGeoIdRemoved(Boolean removed)
    {
        this.isPropertyPostalCodeGeoIdRemoved = removed;
    }

    private Boolean isPropertyGeoPointIdRemoved;

    public Boolean getIsPropertyGeoPointIdRemoved()
    {
        return this.isPropertyGeoPointIdRemoved;
    }

    public void setIsPropertyGeoPointIdRemoved(Boolean removed)
    {
        this.isPropertyGeoPointIdRemoved = removed;
    }

    private Boolean isPropertyCountryCodeRemoved;

    public Boolean getIsPropertyCountryCodeRemoved()
    {
        return this.isPropertyCountryCodeRemoved;
    }

    public void setIsPropertyCountryCodeRemoved(Boolean removed)
    {
        this.isPropertyCountryCodeRemoved = removed;
    }

    private Boolean isPropertyAreaCodeRemoved;

    public Boolean getIsPropertyAreaCodeRemoved()
    {
        return this.isPropertyAreaCodeRemoved;
    }

    public void setIsPropertyAreaCodeRemoved(Boolean removed)
    {
        this.isPropertyAreaCodeRemoved = removed;
    }

    private Boolean isPropertyContactNumberRemoved;

    public Boolean getIsPropertyContactNumberRemoved()
    {
        return this.isPropertyContactNumberRemoved;
    }

    public void setIsPropertyContactNumberRemoved(Boolean removed)
    {
        this.isPropertyContactNumberRemoved = removed;
    }

    private Boolean isPropertyAskForNameRemoved;

    public Boolean getIsPropertyAskForNameRemoved()
    {
        return this.isPropertyAskForNameRemoved;
    }

    public void setIsPropertyAskForNameRemoved(Boolean removed)
    {
        this.isPropertyAskForNameRemoved = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved()
    {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed)
    {
        this.isPropertyActiveRemoved = removed;
    }

    public void copyTo(AbstractContactMechCommand.AbstractCreateOrMergePatchContactMech command)
    {
        ((AbstractContactMechCommandDto) this).copyTo(command);
        command.setContactMechTypeId(this.getContactMechTypeId());
        command.setInfoString(this.getInfoString());
        command.setToName(this.getToName());
        command.setAttnName(this.getAttnName());
        command.setAddress1(this.getAddress1());
        command.setAddress2(this.getAddress2());
        command.setDirections(this.getDirections());
        command.setCity(this.getCity());
        command.setPostalCode(this.getPostalCode());
        command.setPostalCodeExt(this.getPostalCodeExt());
        command.setCountryGeoId(this.getCountryGeoId());
        command.setStateProvinceGeoId(this.getStateProvinceGeoId());
        command.setCountyGeoId(this.getCountyGeoId());
        command.setPostalCodeGeoId(this.getPostalCodeGeoId());
        command.setGeoPointId(this.getGeoPointId());
        command.setCountryCode(this.getCountryCode());
        command.setAreaCode(this.getAreaCode());
        command.setContactNumber(this.getContactNumber());
        command.setAskForName(this.getAskForName());
        command.setActive(this.getActive());
    }

    public ContactMechCommand toCommand()
    {
        if (getCommandType() == null) {
            setCommandType(COMMAND_TYPE_MERGE_PATCH);
        }
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractContactMechCommand.SimpleCreateContactMech command = new AbstractContactMechCommand.SimpleCreateContactMech();
            copyTo((AbstractContactMechCommand.AbstractCreateContactMech) command);
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractContactMechCommand.SimpleMergePatchContactMech command = new AbstractContactMechCommand.SimpleMergePatchContactMech();
            copyTo((AbstractContactMechCommand.SimpleMergePatchContactMech) command);
            return command;
        } 
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractContactMechCommand.AbstractCreateContactMech command)
    {
        copyTo((AbstractContactMechCommand.AbstractCreateOrMergePatchContactMech) command);
    }

    public void copyTo(AbstractContactMechCommand.AbstractMergePatchContactMech command)
    {
        copyTo((AbstractContactMechCommand.AbstractCreateOrMergePatchContactMech) command);
        command.setIsPropertyContactMechTypeIdRemoved(this.getIsPropertyContactMechTypeIdRemoved());
        command.setIsPropertyInfoStringRemoved(this.getIsPropertyInfoStringRemoved());
        command.setIsPropertyToNameRemoved(this.getIsPropertyToNameRemoved());
        command.setIsPropertyAttnNameRemoved(this.getIsPropertyAttnNameRemoved());
        command.setIsPropertyAddress1Removed(this.getIsPropertyAddress1Removed());
        command.setIsPropertyAddress2Removed(this.getIsPropertyAddress2Removed());
        command.setIsPropertyDirectionsRemoved(this.getIsPropertyDirectionsRemoved());
        command.setIsPropertyCityRemoved(this.getIsPropertyCityRemoved());
        command.setIsPropertyPostalCodeRemoved(this.getIsPropertyPostalCodeRemoved());
        command.setIsPropertyPostalCodeExtRemoved(this.getIsPropertyPostalCodeExtRemoved());
        command.setIsPropertyCountryGeoIdRemoved(this.getIsPropertyCountryGeoIdRemoved());
        command.setIsPropertyStateProvinceGeoIdRemoved(this.getIsPropertyStateProvinceGeoIdRemoved());
        command.setIsPropertyCountyGeoIdRemoved(this.getIsPropertyCountyGeoIdRemoved());
        command.setIsPropertyPostalCodeGeoIdRemoved(this.getIsPropertyPostalCodeGeoIdRemoved());
        command.setIsPropertyGeoPointIdRemoved(this.getIsPropertyGeoPointIdRemoved());
        command.setIsPropertyCountryCodeRemoved(this.getIsPropertyCountryCodeRemoved());
        command.setIsPropertyAreaCodeRemoved(this.getIsPropertyAreaCodeRemoved());
        command.setIsPropertyContactNumberRemoved(this.getIsPropertyContactNumberRemoved());
        command.setIsPropertyAskForNameRemoved(this.getIsPropertyAskForNameRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
    }

    public static class CreateContactMechDto extends CreateOrMergePatchContactMechDto
    {
        public CreateContactMechDto() {
            this.commandType = COMMAND_TYPE_CREATE;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public ContactMechCommand.CreateContactMech toCreateContactMech()
        {
            return (ContactMechCommand.CreateContactMech) toCommand();
        }

    }

    public static class MergePatchContactMechDto extends CreateOrMergePatchContactMechDto
    {
        public MergePatchContactMechDto() {
            this.commandType = COMMAND_TYPE_MERGE_PATCH;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public ContactMechCommand.MergePatchContactMech toMergePatchContactMech()
        {
            return (ContactMechCommand.MergePatchContactMech) toCommand();
        }

    }

}

