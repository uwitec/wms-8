﻿<?php

namespace Wms\Domain;

use JMS\Serializer\Annotation\Type;

trait OrganizationIsPropertyRemovedTrait
{
    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyNameRemoved = null;

    /**
     * @return boolean
     */
    public function getIsPropertyNameRemoved()
    {
        return $this->isPropertyNameRemoved;
    }

    /**
     * @param boolean $isPropertyNameRemoved
     */
    public function setIsPropertyNameRemoved($isPropertyNameRemoved)
    {
        $this->isPropertyNameRemoved = $isPropertyNameRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyDescriptionRemoved = null;

    /**
     * @return boolean
     */
    public function getIsPropertyDescriptionRemoved()
    {
        return $this->isPropertyDescriptionRemoved;
    }

    /**
     * @param boolean $isPropertyDescriptionRemoved
     */
    public function setIsPropertyDescriptionRemoved($isPropertyDescriptionRemoved)
    {
        $this->isPropertyDescriptionRemoved = $isPropertyDescriptionRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyTypeRemoved = null;

    /**
     * @return boolean
     */
    public function getIsPropertyTypeRemoved()
    {
        return $this->isPropertyTypeRemoved;
    }

    /**
     * @param boolean $isPropertyTypeRemoved
     */
    public function setIsPropertyTypeRemoved($isPropertyTypeRemoved)
    {
        $this->isPropertyTypeRemoved = $isPropertyTypeRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyIsSummaryRemoved = null;

    /**
     * @return boolean
     */
    public function getIsPropertyIsSummaryRemoved()
    {
        return $this->isPropertyIsSummaryRemoved;
    }

    /**
     * @param boolean $isPropertyIsSummaryRemoved
     */
    public function setIsPropertyIsSummaryRemoved($isPropertyIsSummaryRemoved)
    {
        $this->isPropertyIsSummaryRemoved = $isPropertyIsSummaryRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyActiveRemoved = null;

    /**
     * @return boolean
     */
    public function getIsPropertyActiveRemoved()
    {
        return $this->isPropertyActiveRemoved;
    }

    /**
     * @param boolean $isPropertyActiveRemoved
     */
    public function setIsPropertyActiveRemoved($isPropertyActiveRemoved)
    {
        $this->isPropertyActiveRemoved = $isPropertyActiveRemoved;
    }


}

