﻿<?php

namespace Wms\Domain;

use JMS\Serializer\Annotation\Type;
use NodaMoney\Money;
use Wms\Domain\InOutLine;
use Wms\Domain\SkuId;


trait InOutStatePropertiesTrait
{

    /**
     * @Type("string")
     */
    private $documentNumber;

    /**
     * @return string
     */
    public function getDocumentNumber()
    {
        return $this->documentNumber;
    }

    /**
     * @param string $documentNumber
     */
    public function setDocumentNumber($documentNumber)
    {
        $this->documentNumber = $documentNumber;
    }

    /**
     * @Type("boolean")
     */
    private $isSoTransaction;

    /**
     * @return boolean
     */
    public function getIsSoTransaction()
    {
        return $this->isSoTransaction;
    }

    /**
     * @param boolean $isSoTransaction
     */
    public function setIsSoTransaction($isSoTransaction)
    {
        $this->isSoTransaction = $isSoTransaction;
    }

    /**
     * @Type("string")
     */
    private $documentStatus;

    /**
     * @return string
     */
    public function getDocumentStatus()
    {
        return $this->documentStatus;
    }

    /**
     * @param string $documentStatus
     */
    public function setDocumentStatus($documentStatus)
    {
        $this->documentStatus = $documentStatus;
    }

    /**
     * @Type("boolean")
     */
    private $posted;

    /**
     * @return boolean
     */
    public function getPosted()
    {
        return $this->posted;
    }

    /**
     * @param boolean $posted
     */
    public function setPosted($posted)
    {
        $this->posted = $posted;
    }

    /**
     * @Type("boolean")
     */
    private $processing;

    /**
     * @return boolean
     */
    public function getProcessing()
    {
        return $this->processing;
    }

    /**
     * @param boolean $processing
     */
    public function setProcessing($processing)
    {
        $this->processing = $processing;
    }

    /**
     * @Type("boolean")
     */
    private $processed;

    /**
     * @return boolean
     */
    public function getProcessed()
    {
        return $this->processed;
    }

    /**
     * @param boolean $processed
     */
    public function setProcessed($processed)
    {
        $this->processed = $processed;
    }

    /**
     * @Type("integer")
     */
    private $documentType;

    /**
     * @return integer
     */
    public function getDocumentType()
    {
        return $this->documentType;
    }

    /**
     * @param integer $documentType
     */
    public function setDocumentType($documentType)
    {
        $this->documentType = $documentType;
    }

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
     * @Type("string")
     */
    private $orderNumber;

    /**
     * @return string
     */
    public function getOrderNumber()
    {
        return $this->orderNumber;
    }

    /**
     * @param string $orderNumber
     */
    public function setOrderNumber($orderNumber)
    {
        $this->orderNumber = $orderNumber;
    }

    /**
     * @Type("\DateTime")
     */
    private $dateOrdered;

    /**
     * @return \DateTime
     */
    public function getDateOrdered()
    {
        return $this->dateOrdered;
    }

    /**
     * @param \DateTime $dateOrdered
     */
    public function setDateOrdered($dateOrdered)
    {
        $this->dateOrdered = $dateOrdered;
    }

    /**
     * @Type("boolean")
     */
    private $isPrinted;

    /**
     * @return boolean
     */
    public function getIsPrinted()
    {
        return $this->isPrinted;
    }

    /**
     * @param boolean $isPrinted
     */
    public function setIsPrinted($isPrinted)
    {
        $this->isPrinted = $isPrinted;
    }

    /**
     * @Type("string")
     */
    private $movementType;

    /**
     * @return string
     */
    public function getMovementType()
    {
        return $this->movementType;
    }

    /**
     * @param string $movementType
     */
    public function setMovementType($movementType)
    {
        $this->movementType = $movementType;
    }

    /**
     * @Type("\DateTime")
     */
    private $movementDate;

    /**
     * @return \DateTime
     */
    public function getMovementDate()
    {
        return $this->movementDate;
    }

    /**
     * @param \DateTime $movementDate
     */
    public function setMovementDate($movementDate)
    {
        $this->movementDate = $movementDate;
    }

    /**
     * @Type("string")
     */
    private $businessPartnerId;

    /**
     * @return string
     */
    public function getBusinessPartnerId()
    {
        return $this->businessPartnerId;
    }

    /**
     * @param string $businessPartnerId
     */
    public function setBusinessPartnerId($businessPartnerId)
    {
        $this->businessPartnerId = $businessPartnerId;
    }

    /**
     * @Type("string")
     */
    private $warehouseId;

    /**
     * @return string
     */
    public function getWarehouseId()
    {
        return $this->warehouseId;
    }

    /**
     * @param string $warehouseId
     */
    public function setWarehouseId($warehouseId)
    {
        $this->warehouseId = $warehouseId;
    }

    /**
     * @Type("string")
     */
    private $poReference;

    /**
     * @return string
     */
    public function getPoReference()
    {
        return $this->poReference;
    }

    /**
     * @param string $poReference
     */
    public function setPoReference($poReference)
    {
        $this->poReference = $poReference;
    }

    /**
     * @Type("NodaMoney\Money")
     */
    private $freightAmount;

    /**
     * @return Money
     */
    public function getFreightAmount()
    {
        return $this->freightAmount;
    }

    /**
     * @param Money $freightAmount
     */
    public function setFreightAmount($freightAmount)
    {
        $this->freightAmount = $freightAmount;
    }

    /**
     * @Type("string")
     */
    private $shipperId;

    /**
     * @return string
     */
    public function getShipperId()
    {
        return $this->shipperId;
    }

    /**
     * @param string $shipperId
     */
    public function setShipperId($shipperId)
    {
        $this->shipperId = $shipperId;
    }

    /**
     * @Type("NodaMoney\Money")
     */
    private $chargeAmount;

    /**
     * @return Money
     */
    public function getChargeAmount()
    {
        return $this->chargeAmount;
    }

    /**
     * @param Money $chargeAmount
     */
    public function setChargeAmount($chargeAmount)
    {
        $this->chargeAmount = $chargeAmount;
    }

    /**
     * @Type("\DateTime")
     */
    private $datePrinted;

    /**
     * @return \DateTime
     */
    public function getDatePrinted()
    {
        return $this->datePrinted;
    }

    /**
     * @param \DateTime $datePrinted
     */
    public function setDatePrinted($datePrinted)
    {
        $this->datePrinted = $datePrinted;
    }

    /**
     * @Type("string")
     */
    private $salesRepresentative;

    /**
     * @return string
     */
    public function getSalesRepresentative()
    {
        return $this->salesRepresentative;
    }

    /**
     * @param string $salesRepresentative
     */
    public function setSalesRepresentative($salesRepresentative)
    {
        $this->salesRepresentative = $salesRepresentative;
    }

    /**
     * @Type("integer")
     */
    private $numberOfPackages;

    /**
     * @return integer
     */
    public function getNumberOfPackages()
    {
        return $this->numberOfPackages;
    }

    /**
     * @param integer $numberOfPackages
     */
    public function setNumberOfPackages($numberOfPackages)
    {
        $this->numberOfPackages = $numberOfPackages;
    }

    /**
     * @Type("\DateTime")
     */
    private $pickDate;

    /**
     * @return \DateTime
     */
    public function getPickDate()
    {
        return $this->pickDate;
    }

    /**
     * @param \DateTime $pickDate
     */
    public function setPickDate($pickDate)
    {
        $this->pickDate = $pickDate;
    }

    /**
     * @Type("\DateTime")
     */
    private $shipDate;

    /**
     * @return \DateTime
     */
    public function getShipDate()
    {
        return $this->shipDate;
    }

    /**
     * @param \DateTime $shipDate
     */
    public function setShipDate($shipDate)
    {
        $this->shipDate = $shipDate;
    }

    /**
     * @Type("string")
     */
    private $trackingNumber;

    /**
     * @return string
     */
    public function getTrackingNumber()
    {
        return $this->trackingNumber;
    }

    /**
     * @param string $trackingNumber
     */
    public function setTrackingNumber($trackingNumber)
    {
        $this->trackingNumber = $trackingNumber;
    }

    /**
     * @Type("\DateTime")
     */
    private $dateReceived;

    /**
     * @return \DateTime
     */
    public function getDateReceived()
    {
        return $this->dateReceived;
    }

    /**
     * @param \DateTime $dateReceived
     */
    public function setDateReceived($dateReceived)
    {
        $this->dateReceived = $dateReceived;
    }

    /**
     * @Type("boolean")
     */
    private $isInTransit;

    /**
     * @return boolean
     */
    public function getIsInTransit()
    {
        return $this->isInTransit;
    }

    /**
     * @param boolean $isInTransit
     */
    public function setIsInTransit($isInTransit)
    {
        $this->isInTransit = $isInTransit;
    }

    /**
     * @Type("boolean")
     */
    private $isApproved;

    /**
     * @return boolean
     */
    public function getIsApproved()
    {
        return $this->isApproved;
    }

    /**
     * @param boolean $isApproved
     */
    public function setIsApproved($isApproved)
    {
        $this->isApproved = $isApproved;
    }

    /**
     * @Type("boolean")
     */
    private $isInDispute;

    /**
     * @return boolean
     */
    public function getIsInDispute()
    {
        return $this->isInDispute;
    }

    /**
     * @param boolean $isInDispute
     */
    public function setIsInDispute($isInDispute)
    {
        $this->isInDispute = $isInDispute;
    }

    /**
     * @Type("decimal")
     */
    private $volume;

    /**
     * @return decimal
     */
    public function getVolume()
    {
        return $this->volume;
    }

    /**
     * @param decimal $volume
     */
    public function setVolume($volume)
    {
        $this->volume = $volume;
    }

    /**
     * @Type("decimal")
     */
    private $weight;

    /**
     * @return decimal
     */
    public function getWeight()
    {
        return $this->weight;
    }

    /**
     * @param decimal $weight
     */
    public function setWeight($weight)
    {
        $this->weight = $weight;
    }

    /**
     * @Type("string")
     */
    private $rmaNumber;

    /**
     * @return string
     */
    public function getRmaNumber()
    {
        return $this->rmaNumber;
    }

    /**
     * @param string $rmaNumber
     */
    public function setRmaNumber($rmaNumber)
    {
        $this->rmaNumber = $rmaNumber;
    }

    /**
     * @Type("string")
     */
    private $reversalNumber;

    /**
     * @return string
     */
    public function getReversalNumber()
    {
        return $this->reversalNumber;
    }

    /**
     * @param string $reversalNumber
     */
    public function setReversalNumber($reversalNumber)
    {
        $this->reversalNumber = $reversalNumber;
    }

    /**
     * @Type("boolean")
     */
    private $isDropShip;

    /**
     * @return boolean
     */
    public function getIsDropShip()
    {
        return $this->isDropShip;
    }

    /**
     * @param boolean $isDropShip
     */
    public function setIsDropShip($isDropShip)
    {
        $this->isDropShip = $isDropShip;
    }

    /**
     * @Type("string")
     */
    private $dropShipBusinessPartnerId;

    /**
     * @return string
     */
    public function getDropShipBusinessPartnerId()
    {
        return $this->dropShipBusinessPartnerId;
    }

    /**
     * @param string $dropShipBusinessPartnerId
     */
    public function setDropShipBusinessPartnerId($dropShipBusinessPartnerId)
    {
        $this->dropShipBusinessPartnerId = $dropShipBusinessPartnerId;
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
     * @Type("long")
     */
    private $version;

    /**
     * @return long
     */
    public function getVersion()
    {
        return $this->version;
    }

    /**
     * @param long $version
     */
    public function setVersion($version)
    {
        $this->version = $version;
    }

    /**
     * @Type("string")
     */
    private $createdBy;

    /**
     * @return string
     */
    public function getCreatedBy()
    {
        return $this->createdBy;
    }

    /**
     * @param string $createdBy
     */
    public function setCreatedBy($createdBy)
    {
        $this->createdBy = $createdBy;
    }

    /**
     * @Type("\DateTime")
     */
    private $createdAt;

    /**
     * @return \DateTime
     */
    public function getCreatedAt()
    {
        return $this->createdAt;
    }

    /**
     * @param \DateTime $createdAt
     */
    public function setCreatedAt($createdAt)
    {
        $this->createdAt = $createdAt;
    }

    /**
     * @Type("string")
     */
    private $updatedBy;

    /**
     * @return string
     */
    public function getUpdatedBy()
    {
        return $this->updatedBy;
    }

    /**
     * @param string $updatedBy
     */
    public function setUpdatedBy($updatedBy)
    {
        $this->updatedBy = $updatedBy;
    }

    /**
     * @Type("\DateTime")
     */
    private $updatedAt;

    /**
     * @return \DateTime
     */
    public function getUpdatedAt()
    {
        return $this->updatedAt;
    }

    /**
     * @param \DateTime $updatedAt
     */
    public function setUpdatedAt($updatedAt)
    {
        $this->updatedAt = $updatedAt;
    }


}
