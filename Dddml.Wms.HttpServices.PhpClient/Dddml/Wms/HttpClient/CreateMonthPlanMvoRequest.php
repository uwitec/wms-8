<?php

namespace Dddml\Wms\HttpClient;

use Dddml\Executor\Http\CommandExecutor;
use Dddml\Executor\Http\AbstractCommandRequest;
use Dddml\Routing\RouteTrait;
use JMS\Serializer\Annotation\Type;
use Symfony\Component\Routing\Route;
use Dddml\Serializer\Type\Long;
use Dddml\Wms\Domain\CreateOrMergePatchMonthPlanMvo;


class CreateMonthPlanMvoRequest extends AbstractCommandRequest
{
    use RouteTrait;

    /**
     * @var  CreateOrMergePatchMonthPlanMvo
     */
    private $command;

    public static $commandType = 'Dddml\Wms\Domain\CreateOrMergePatchMonthPlanMvo';

    public function __construct(CommandExecutor $executor)
    {
        parent::__construct($executor);
        $command = $this->getCommand();
        $command->setCommandType(static::COMMAND_CREATE);

        $this->route = new Route('MonthPlanMvos/{id}');
    }

    public function getMethod()
    {
        return CommandExecutor::METHOD_PUT;
    }

    /**
     * @return  CreateOrMergePatchMonthPlanMvo
     */
    public function getCommand()
    {
        if (!$this->command) {
            $this->command = new CreateOrMergePatchMonthPlanMvo();
        }

        return $this->command;
    }
}
