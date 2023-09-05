class App {
    protected Empresa Empresa_;
    protected Interface Interface_;

    public App(Empresa empresa, Interface interface_) {
        Empresa_ = empresa;
        Interface_ = interface_;
    }

    public void Executar() {
        Empresa_.ProcessarFolha(Interface_);
    }
}
