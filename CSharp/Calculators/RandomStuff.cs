public class RandomStuff {
    public void Calculate(Client client) {
        Group yukon = client.yukon;
        Group quebec = client.quebec;

        yukon.R[10] = yukon.R[0] + yukon.R[1];
        quebec.R[10] = quebec.R[0] + yukon.R[1];
    }
}