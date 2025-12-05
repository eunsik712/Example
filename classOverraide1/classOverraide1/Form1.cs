using System.Security.Cryptography.X509Certificates;

namespace classOverraide1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Character player = new Warrior(30); // 전사 생성
            Character monster = new Orc(20); // 오크 생성
            Character slime = new Slime(10); // 슬라임 생성
            Character wizard = new Wizard(25); // 마법사 생성
            // 전사 vs 오크 전투
            Battle.Fight(player, monster);
            // 마법사 vs 슬라임 전투
            Battle.Fight(wizard, slime);

        }


        // 게임 구현
        // 캐릭터 클래스 (부모) 생성 후 플레이어, 몬스터 클래스에 상속
        // 플레어어, 몬스터 클래스에서 캐릭터 클래스의 메서드 오버라이딩
        // 플레이어의 직업과 몬스터 종류를 구분하기위해 또 다른 클래스 생성 후 상속


        


        public class Character
        {
            private static readonly Random Rand = new Random();
            public string Job;
            public int Hp = 100;
            public int Power;
            public int SkillPower = Rand.Next(20, 60);
            public Character(string Job, int power)
            {
                this.Job = Job;
                this.Power = power;
            }

            public virtual void Attack(Character target)
            {
                MessageBox.Show("캐릭터가 공격합니다.");
                target.Hp -= this.Power;
            }

            public virtual void Die()
            {
                if (Hp <= 0)
                    MessageBox.Show("캐릭터가 사망했습니다.");
            }

            public virtual void Speak()
            {
                MessageBox.Show("캐릭터가 말합니다.");
            }

            public virtual void Move()
            {
                MessageBox.Show("캐릭터가 이동합니다.");
            }

            public virtual void Skill()
            {
                MessageBox.Show("캐릭터가 스킬을 사용합니다.");
            }
        }

        public class Player : Character
        {
            // 직업 선택
            public Player(string Job, int Power) : base(Job, Power) { }

        }

        public class Monster : Character
        {
            // 직업 선택
            public Monster(string Job, int Power) : base(Job, Power) { }

        }

        public class Warrior : Player
        {

            // 전사 선택시
            public Warrior(int Power) : base("전사", Power) { }


            public override void Speak()
            {
                MessageBox.Show("전사가 외칩니다: 나는 용감한 전사다!");
            }
            public override void Move()
            {
                MessageBox.Show("전사가 빠르게 달립니다.");
            }

            public override void Attack(Character target)
            {
                base.Attack(target);
            }
            

            public override void Skill()
            {
                MessageBox.Show("전사가 강력한 베기 스킬을 사용합니다.");
            }

            public override void Die()
            {
                if (Hp <= 0)
                    MessageBox.Show("전사가 용감하게 쓰러졌습니다.");
            }

        }


        public class Wizard : Player
        {
            // 마법사 선택시
            public Wizard(int Power) : base("마법사", Power) { }

            public override void Speak()
            {
                MessageBox.Show("마법사가 속삭입니다: 지식은 힘이다.");
            }

            public override void Move()
            {
                MessageBox.Show("마법사가 마법으로 순간이동합니다.");
            }

            public override void Attack(Character target)
            {
                base.Attack(target);
                MessageBox.Show("마법사가 마법으로 공격합니다!");
            }

            public override void Skill()
            {
                MessageBox.Show("마법사가 강력한 화염구 스킬을 사용합니다.");
            }

            public override void Die()
            {
                if (Hp <= 0)
                    MessageBox.Show("마법사가 조용히 쓰러졌습니다.");
            }

        }

        public class Orc : Monster
        {
            public Orc(int Power) : base("오크", Power) { }

            public override void Speak()
            {
                MessageBox.Show("오크가 으르렁거립니다: 우르르르!");
            }
            public override void Move()
            {
                MessageBox.Show("오크가 무겁게 걸어갑니다.");
            }
            public override void Attack(Character target)
            {
                base.Attack(target);
                MessageBox.Show("오크가 도끼로 공격합니다!");
            }
            public override void Skill()
            {
                MessageBox.Show("오크가 강력한 돌진 스킬을 사용합니다.");
            }
            public override void Die()
            {
                if (Hp <= 0)
                    MessageBox.Show("오크가 쓰러졌습니다.");
            }

        }

        public class Slime : Monster
        {
            public Slime(int Power) : base("슬라임", Power) { }
            public override void Speak()
            {
                MessageBox.Show("슬라임이 끈적거리며 말합니다: 젤리젤리!");
            }
            public override void Move()
            {
                MessageBox.Show("슬라임이 천천히 기어갑니다.");
            }
            public override void Attack(Character target)
            {
                base.Attack(target);
                MessageBox.Show("슬라임이 몸통박치기로 공격합니다!");
            }
            public override void Skill()
            {
                MessageBox.Show("슬라임이 분열 스킬을 사용합니다.");
            }
            public override void Die()
            {
                if (Hp <= 0)
                    MessageBox.Show("슬라임이 녹아내렸습니다.");
            }
        }
        public class Battle
        {
            // 랜덤 값을 뽑기 위한 도구
            private static Random rand = new Random();

            public static void Fight(Character player, Character monster)
            {
                // 전투 시작 대사 (한 번만 출력)
                player.Speak();
                monster.Speak();

                while (player.Hp > 0 && monster.Hp > 0)
                {
                    // ==========================
                    // 1. 플레이어의 턴
                    // ==========================

                    // 행동 결정 (0~9 사이 숫자 뽑기)
                    int actionDice = rand.Next(10);

                    // [10% 확률] 공격 전 가끔 대사 침
                    if (rand.Next(10) == 0) player.Speak();

                    if (actionDice < 3) // 30% 확률로 스킬 사용 (0, 1, 2)
                    {
                        player.Skill(); // 스킬 대사/모션 출력
                        monster.Hp -= player.SkillPower; // 스킬 데미지 적용
                        MessageBox.Show($"{player.Job}의 스킬 적중! (데미지: {player.SkillPower})");
                    }
                    else // 70% 확률로 일반 공격
                    {
                        // [50% 확률] 공격 전 이동 모션
                        if (rand.Next(2) == 0) player.Move();

                        player.Attack(monster); // 일반 공격 (메서드 안에서 데미지 처리 됨)
                    }

                    // 몬스터 사망 체크
                    if (monster.Hp <= 0)
                    {
                        monster.Die();
                        MessageBox.Show($"전투 승리! 남은 체력: {player.Hp}");
                        break;
                    }

                    // ==========================
                    // 2. 몬스터의 턴
                    // ==========================

                    actionDice = rand.Next(10);

                    // [10% 확률] 몬스터도 가끔 대사 침
                    if (rand.Next(10) == 0) monster.Speak();

                    if (actionDice < 3) // 30% 확률로 스킬 사용
                    {
                        monster.Skill();
                        player.Hp -= monster.SkillPower;
                        MessageBox.Show($"{monster.Job}의 스킬 공격! (데미지: {monster.SkillPower})");
                    }
                    else // 70% 확률로 일반 공격
                    {
                        if (rand.Next(2) == 0) monster.Move();
                        monster.Attack(player);
                    }

                    // 플레이어 사망 체크
                    if (player.Hp <= 0)
                    {
                        player.Die();
                        MessageBox.Show("패배했습니다... 게임 오버");
                        break;
                    }
                }
            }
        }
    }




    
}
