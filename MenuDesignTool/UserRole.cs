using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDesignTool
{
    public enum UserRole : int
    {
        前台未登录,
        派班角色登录,
        调度登录,
        维护登录,
        车务终端监视员登录,
        调度主任登录,
        现地值班员未登录,
        现地值班员登录,
        后台登未录,
        后台登录,
        编图员未登录,
        编图员登录,
        管理员登录
    }
}
