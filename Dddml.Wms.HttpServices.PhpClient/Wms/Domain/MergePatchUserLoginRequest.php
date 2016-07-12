﻿<?php

namespace Wms\Domain;

use Dddml\Command\CommandExecutor;
use Dddml\Command\CommandRequestInterface;
use Dddml\Routing\RouteTrait;
use JMS\Serializer\Annotation\Type;
use Symfony\Component\Routing\Route;
use Wms\Domain\LoginKey;

class MergePatchUserLoginRequest implements CommandRequestInterface
{
    use RouteTrait;

    /**
     * @var  CreateOrMergePatchUserLogin
     */
    private $command;

    public function __construct()
    {
        $command = $this->getCommand();
        $command->setCommandType(static::COMMAND_MERGE_PATCH);

        $this->route = new Route('Users/{id}');
    }

    public function getMethod()
    {
        return CommandExecutor::METHOD_PATCH;
    }

    /**
     * @return  CreateOrMergePatchUserLogin
     */
    public function getCommand()
    {
        if (!$this->command) {
            $this->command = new CreateOrMergePatchUserLogin();
        }

        return $this->command;
    }
}
