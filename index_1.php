<?php
class A{
}
class B extends A{
    public function __construct($a){
        $this->a = $a;
    }

    protected $a;
}
class C extends B{
    public function __construct($a, $b){
        $this->b = $b;
        $this->b = $c;
        $this->b = $d;
        parent::__construct($a);
    }

    protected $b;
    protected $c;
    protected $d;
}
$a1 = new A();
$a2 = new A();
$a3 = new A();
$b4 = new B($a1);
$c5 = new C($a1,$a2,$a3,$b4);
echo var_dump($c5);

?>