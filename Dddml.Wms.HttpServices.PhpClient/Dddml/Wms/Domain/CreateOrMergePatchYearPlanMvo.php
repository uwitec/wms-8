<?php

namespace Dddml\Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Dddml\Serializer\Type\Long;
use Dddml\Wms\Domain\CommandTrait;

class CreateOrMergePatchYearPlanMvo extends AbstractYearPlanMvoCommand
{

    use YearPlanMvoIsPropertyRemovedTrait;

    /**
     * @Type("string")
     */
    private $description;

    /**
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * @param string $description
     */
    public function setDescription($description)
    {
        $this->description = $description;
    }

    /**
     * @Type("Dddml\Serializer\Type\Long")
     */
    private $version;

    /**
     * @return Long
     */
    public function getVersion()
    {
        return $this->version;
    }

    /**
     * @param Long $version
     */
    public function setVersion($version)
    {
        $this->version = $version;
    }

    /**
     * @Type("boolean")
     */
    private $active;

    /**
     * @return boolean
     */
    public function getActive()
    {
        return $this->active;
    }

    /**
     * @param boolean $active
     */
    public function setActive($active)
    {
        $this->active = $active;
    }

    /**
     * @Type("DateTime")
     */
    private $personBirthDate;

    /**
     * @return \DateTime
     */
    public function getPersonBirthDate()
    {
        return $this->personBirthDate;
    }

    /**
     * @param \DateTime $personBirthDate
     */
    public function setPersonBirthDate($personBirthDate)
    {
        $this->personBirthDate = $personBirthDate;
    }

    /**
     * @Type("Dddml\Wms\Domain\PersonalName")
     */
    private $personLoves;

    /**
     * @return PersonalName
     */
    public function getPersonLoves()
    {
        return $this->personLoves;
    }

    /**
     * @param PersonalName $personLoves
     */
    public function setPersonLoves($personLoves)
    {
        $this->personLoves = $personLoves;
    }

    /**
     * @Type("Dddml\Wms\Domain\Contact")
     */
    private $personEmergencyContact;

    /**
     * @return Contact
     */
    public function getPersonEmergencyContact()
    {
        return $this->personEmergencyContact;
    }

    /**
     * @param Contact $personEmergencyContact
     */
    public function setPersonEmergencyContact($personEmergencyContact)
    {
        $this->personEmergencyContact = $personEmergencyContact;
    }

    /**
     * @Type("string")
     */
    private $personEmail;

    /**
     * @return string
     */
    public function getPersonEmail()
    {
        return $this->personEmail;
    }

    /**
     * @param string $personEmail
     */
    public function setPersonEmail($personEmail)
    {
        $this->personEmail = $personEmail;
    }

    /**
     * @Type("string")
     */
    private $personCreatedBy;

    /**
     * @return string
     */
    public function getPersonCreatedBy()
    {
        return $this->personCreatedBy;
    }

    /**
     * @param string $personCreatedBy
     */
    public function setPersonCreatedBy($personCreatedBy)
    {
        $this->personCreatedBy = $personCreatedBy;
    }

    /**
     * @Type("string")
     */
    private $personUpdatedBy;

    /**
     * @return string
     */
    public function getPersonUpdatedBy()
    {
        return $this->personUpdatedBy;
    }

    /**
     * @param string $personUpdatedBy
     */
    public function setPersonUpdatedBy($personUpdatedBy)
    {
        $this->personUpdatedBy = $personUpdatedBy;
    }

    /**
     * @Type("DateTime")
     */
    private $personCreatedAt;

    /**
     * @return \DateTime
     */
    public function getPersonCreatedAt()
    {
        return $this->personCreatedAt;
    }

    /**
     * @param \DateTime $personCreatedAt
     */
    public function setPersonCreatedAt($personCreatedAt)
    {
        $this->personCreatedAt = $personCreatedAt;
    }

    /**
     * @Type("DateTime")
     */
    private $personUpdatedAt;

    /**
     * @return \DateTime
     */
    public function getPersonUpdatedAt()
    {
        return $this->personUpdatedAt;
    }

    /**
     * @param \DateTime $personUpdatedAt
     */
    public function setPersonUpdatedAt($personUpdatedAt)
    {
        $this->personUpdatedAt = $personUpdatedAt;
    }

    /**
     * @Type("boolean")
     */
    private $personActive;

    /**
     * @return boolean
     */
    public function getPersonActive()
    {
        return $this->personActive;
    }

    /**
     * @param boolean $personActive
     */
    public function setPersonActive($personActive)
    {
        $this->personActive = $personActive;
    }

    /**
     * @Type("boolean")
     */
    private $personDeleted;

    /**
     * @return boolean
     */
    public function getPersonDeleted()
    {
        return $this->personDeleted;
    }

    /**
     * @param boolean $personDeleted
     */
    public function setPersonDeleted($personDeleted)
    {
        $this->personDeleted = $personDeleted;
    }


}

