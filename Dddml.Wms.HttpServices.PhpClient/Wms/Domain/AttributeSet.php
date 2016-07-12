﻿<?php

namespace Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Wms\Domain\AttributeUse;

class AttributeSet
{

    use AttributeSetStatePropertiesTrait;

    /**
     * @Type("array<Wms\Domain\AttributeUse>")
     * @var AttributeUse[]
     */
    private $attributeUses;

    /**
     * @return AttributeUse[]
     */
    public function getAttributeUses()
    {
        return $this->attributeUses;
    }	

    /**
     * @param AttributeUse[] $attributeUses
     */
    public function setAttributeUses($attributeUses)
    {
        $this->attributeUses = $attributeUses;
    }


}

