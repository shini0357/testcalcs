public class Alberta {
    public void Calculate(Client client) {
        Group alberta = client.alberta;
        alberta.R[10] = alberta.R[0] + alberta.R[1];

        if (alberta.R[10] > 50) {
            alberta.R[11] = alberta.R[10] * 10;
        }
    }
}