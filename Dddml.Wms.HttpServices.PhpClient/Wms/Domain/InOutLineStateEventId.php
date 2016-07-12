﻿<?php

namespace Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Wms\Domain\SkuId;

class InOutLineStateEventId
{
    /**
     * @Type("string")
     */
    private $inOutDocumentNumber;

    /**
     * @return string
     */
    public function getInOutDocumentNumber()
    {
        return $this->inOutDocumentNumber;
    }

    /**
     * @param string $inOutDocumentNumber
     */
    public function setInOutDocumentNumber($inOutDocumentNumber)
    {
        $this->inOutDocumentNumber = $inOutDocumentNumber;
    }

    /**
     * @Type("Wms\Domain\SkuId")
     */
    private $skuId;

    /**
     * @return SkuId
     */
    public function getSkuId()
    {
        return $this->skuId;
    }

    /**
     * @param SkuId $skuId
     */
    public function setSkuId($skuId)
    {
        $this->skuId = $skuId;
    }

    /**
     * @Type("long")
     */
    private $inOutVersion;

    /**
     * @return long
     */
    public function getInOutVersion()
    {
        return $this->inOutVersion;
    }

    /**
     * @param long $inOutVersion
     */
    public function setInOutVersion($inOutVersion)
    {
        $this->inOutVersion = $inOutVersion;
    }

}

