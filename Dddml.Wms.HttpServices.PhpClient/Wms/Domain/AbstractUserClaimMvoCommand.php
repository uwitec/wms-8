﻿<?php

namespace Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Wms\Domain\UserClaimId;
use Wms\Domain\UserRole;
use Wms\Domain\UserClaim;
use Wms\Domain\UserPermission;
use Wms\Domain\UserLogin;
use Wms\Domain\CommandTrait;

class AbstractUserClaimMvoCommand
{

    use CommandTrait;

    /**
     * @Type("Wms\Domain\UserClaimId")
     */
    private $userClaimId;

    /**
     * @return UserClaimId
     */
    public function getUserClaimId()
    {
        return $this->userClaimId;
    }

    /**
     * @param UserClaimId $userClaimId
     */
    public function setUserClaimId($userClaimId)
    {
        $this->userClaimId = $userClaimId;
    }

    /**
     * @Type("long")
     */
    private $userVersion;

    /**
     * @return long
     */
    public function getUserVersion()
    {
        return $this->userVersion;
    }

    /**
     * @param long $userVersion
     */
    public function setUserVersion($userVersion)
    {
        $this->userVersion = $userVersion;
    }


}
