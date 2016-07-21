<?php

namespace Wms\HttpClient;

use Dddml\Executor\Http\CommandExecutor;
use Dddml\Executor\Http\CommandRequestInterface;
use Dddml\Routing\RouteTrait;
use JMS\Serializer\Annotation\Type;
use Symfony\Component\Routing\Route;
use Wms\Domain\CreateOrMergePatchOrganizationStructure;

class MergePatchOrganizationStructureRequest implements CommandRequestInterface
{
    use RouteTrait;

    /**
     * @var  CreateOrMergePatchOrganizationStructure
     */
    private $command;

    public function __construct()
    {
        $command = $this->getCommand();
        $command->setCommandType(static::COMMAND_MERGE_PATCH);

        $this->route = new Route('OrganizationStructures/{id}');
    }

    public function getMethod()
    {
        return CommandExecutor::METHOD_PATCH;
    }

    /**
     * @return  CreateOrMergePatchOrganizationStructure
     */
    public function getCommand()
    {
        if (!$this->command) {
            $this->command = new CreateOrMergePatchOrganizationStructure();
        }

        return $this->command;
    }
}

