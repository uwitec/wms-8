<?php

namespace Wms\HttpClient;

use Dddml\Executor\Http\CommandExecutor;
use Dddml\Executor\Http\CommandRequestInterface;
use Dddml\Routing\RouteTrait;
use Symfony\Component\Routing\Route;
use Wms\Domain\DeleteAttributeUseMvo;


class DeleteAttributeUseMvoRequest implements CommandRequestInterface
{
    use RouteTrait;

    /**
     * @var DeleteAttributeUseMvo
     */
    private $command;

    public function __construct()
    {
        $this->route = new Route('AttributeUseMvos/{id}');
    }

    public function getMethod()
    {
        return CommandExecutor::METHOD_DELETE;
    }

    /**
     * @return DeleteAttributeUseMvo
     */
    public function getCommand()
    {
        if (!$this->command) {
            $this->command = new DeleteAttributeUseMvo();
        }

        return $this->command;
    }

}

